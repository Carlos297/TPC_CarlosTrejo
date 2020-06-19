using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using System.Data;

namespace Negocio
{



    public class ChoferNegocio
    {
        public List<Chofer> lista;

        public List<Chofer> listar2()
        {
            lista = new List<Chofer>();
            Chofer aux;

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearQery("Select ID, Legajo, Apellidos, Nombres, Sexo, FechaNac, Estado from Choferes where Estado = 'A'");

                datos.ejecutarLector();

                while (datos.lector.Read())
                {
                    aux = new Chofer();

                    //aux.Nombre = (string)lector["nombre"]; OTRA FORMA DE ASIGNACION

                    aux.IdChofer = datos.lector.GetInt32(0);

                    if (!Convert.IsDBNull(datos.lector["Legajo"]))
                        aux.Legajo = datos.lector.GetInt32(1);

                    if (!Convert.IsDBNull(datos.lector["Apellidos"]))
                        aux.Apellido = datos.lector.GetString(2);

                    if (!Convert.IsDBNull(datos.lector["Nombres"]))
                        aux.Nombre = datos.lector.GetString(3);

                    if (!Convert.IsDBNull(datos.lector["Sexo"]))
                        aux.Sexo = datos.lector.GetString(4);

                    if (!Convert.IsDBNull(datos.lector["FechaNac"]))
                        aux.FechaNacimiento = datos.lector.GetDateTime(5);

                    if (!Convert.IsDBNull(datos.lector["Estado"]))
                        aux.Estado = datos.lector.GetString(6);

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





        public void agregar(Chofer nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            


            try
            {

                conexion.ConnectionString = "data source=localhost\\sqlexpress; initial catalog=TP_Final; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "insert into Choferes (Legajo, Apellidos, Nombres, Sexo, FechaNac, Estado) Values (@Legajo, @Apellidos, @Nombres, @Sexo, @FechaNac, @Estado)";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Legajo", nuevo.Legajo.ToString());
                comando.Parameters.AddWithValue("@Apellidos", nuevo.Apellido.ToString());
                comando.Parameters.AddWithValue("@Nombres", nuevo.Nombre.ToString());
                comando.Parameters.AddWithValue("@Sexo", nuevo.Sexo.ToString());
                comando.Parameters.AddWithValue("@FechaNac", nuevo.FechaNacimiento);
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



        public void bajaChofer(string idChofer)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                //SqlCommand cmd = new SqlCommand();
                datos.setearSP("SP_BajaChofer");
                datos.AgregarParametro("@idChofer", idChofer);

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



        public void modificarChofer(Chofer chofer)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                //datos.setearQuery("Update POKEMONS set Nombre=@Nombre Where Id=@Id");
                datos.setearSP("SP_ModificarChofer");
                datos.AgregarParametro("@Id", chofer.IdChofer.ToString());
                datos.AgregarParametro("@Legajo", chofer.Legajo.ToString());
                datos.AgregarParametro("@Apellidos", chofer.Apellido);
                datos.AgregarParametro("@Nombres", chofer.Nombre);
                datos.AgregarParametro("@Sexo", chofer.Sexo);
                datos.AgregarParametro("@FechaNac", chofer.FechaNacimiento.ToString());
                datos.AgregarParametro("@Estado", chofer.Estado);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
    }
}
