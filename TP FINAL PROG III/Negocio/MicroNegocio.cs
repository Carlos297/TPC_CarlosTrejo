using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Negocio;
using Dominio;

namespace Negocio
{
    public class MicroNegocio
    {
        public List<Micro> lista;

        public List<Micro> listar2()
        {
            lista = new List<Micro>();
            Micro aux;

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearQery("Select ID, Patente, Modelo, FechaFabr, CantAsientos, Estado from Micros where Estado = 'A'");

                datos.ejecutarLector();

                while (datos.lector.Read())
                {
                    aux = new Micro();

                    //aux.Nombre = (string)lector["nombre"]; OTRA FORMA DE ASIGNACION

                    aux.IdMicro = datos.lector.GetInt32(0);

                    if (!Convert.IsDBNull(datos.lector["Patente"]))
                        aux.Patente = datos.lector.GetString(1);

                    if (!Convert.IsDBNull(datos.lector["Modelo"]))
                        aux.Modelo = datos.lector.GetInt32(2);


                    if (!Convert.IsDBNull(datos.lector["FechaFabr"]))
                        aux.FechaFabricacion = datos.lector.GetDateTime(3);

                    if (!Convert.IsDBNull(datos.lector["CantAsientos"]))
                        aux.CantAsientos = datos.lector.GetInt32(4);

                    if (!Convert.IsDBNull(datos.lector["Estado"]))
                        aux.Estado = datos.lector.GetString(5);

                    //if (!Convert.IsDBNull(datos.lector["FechaNac"]))
                    //    aux.FechaNacimiento = datos.lector.GetSqlDateTime(3);

                    //if (!Convert.IsDBNull(datos.lector["Estado"]))
                    //    aux.Estado = datos.lector.GetSqlBoolean(3);

                    lista.Add(aux);

                }

                return lista;
            }


            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                datos.cerrarConexion();
            }

        }


        public void agregar(Micro nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();


            try
            {

                conexion.ConnectionString = "data source=localhost\\sqlexpress; initial catalog=TP_Final; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "insert into Micros (Patente, Modelo, FechaFabr, CantAsientos, Estado) Values (@Patente, @Modelo, @FechaFabr, @CantAsientos, @Estado)";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Patente", nuevo.Patente.ToString());
                comando.Parameters.AddWithValue("@Modelo", nuevo.Modelo.ToString());
                comando.Parameters.AddWithValue("@FechaFabr", nuevo.FechaFabricacion);
                comando.Parameters.AddWithValue("@CantAsientos", nuevo.CantAsientos.ToString());
                comando.Parameters.AddWithValue("@Estado", nuevo.Estado.ToString());

                comando.Connection = conexion;

                conexion.Open();
                comando.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {


                conexion.Close();
            }
        }

        public void bajaMicro(string idMicro)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                //SqlCommand cmd = new SqlCommand();
                datos.setearSP("SP_BajaMicro");
                datos.AgregarParametro("@idMicro", idMicro);

                //datos.SetearQery("delete from ARTICULOS where id=" + id);
                datos.ejecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                datos.cerrarConexion();
            }

        }

        public void modificarMicro(Micro micro)
        {
            AccesoDatos datos = new AccesoDatos();
            SqlCommand comando = new SqlCommand();
            try
            {
                //datos.setearQuery("Update POKEMONS set Nombre=@Nombre Where Id=@Id");
                datos.setearSP("SP_ModificarMicro");
                datos.AgregarParametro("@Id", micro.IdMicro.ToString());
                datos.AgregarParametro("@Patente", micro.Patente.ToString());
                datos.AgregarParametro("@Modelo", micro.Modelo.ToString());
                datos.AgregarParametroFecha("@FechaFabr", micro.FechaFabricacion);
                datos.AgregarParametro("@CantAsientos", micro.CantAsientos.ToString());
                datos.AgregarParametro("@Estado", micro.Estado);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
