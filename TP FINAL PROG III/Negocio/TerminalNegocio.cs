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
    public class TerminalNegocio
    {

        public List <Terminal> lista;

        public List<Terminal> listar2()
        {
            lista = new List<Terminal>();

            Terminal aux;

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearQery("Select ID, CodTerminal, NomTerminal, Estado from Terminales where Estado = 'A'");

                datos.ejecutarLector();

                while (datos.lector.Read())
                {
                    aux = new Terminal();

                    //aux.Nombre = (string)lector["nombre"]; OTRA FORMA DE ASIGNACION

                    aux.IdTerminal = datos.lector.GetInt32(0);


                    if (!Convert.IsDBNull(datos.lector["CodTerminal"]))
                        aux.CodTerminal = datos.lector.GetString(1);

                    if (!Convert.IsDBNull(datos.lector["NomTerminal"]))
                        aux.NombreTerminal = datos.lector.GetString(2);


                    if (!Convert.IsDBNull(datos.lector["Estado"]))
                        aux.Estado = datos.lector.GetString(3);

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



        public void agregar(Terminal nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();




            try
            {

                conexion.ConnectionString = "data source=localhost\\sqlexpress; initial catalog=TP_Final; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "insert into Terminales (CodTerminal, NomTerminal, Estado) Values (@CodTerminal, @NomTerminal, @Estado)";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@CodTerminal", nuevo.CodTerminal.ToString());
                comando.Parameters.AddWithValue("@NomTerminal", nuevo.NombreTerminal.ToString());
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



        public void bajaTerminal(string idTerminal)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                //SqlCommand cmd = new SqlCommand();
                datos.setearSP("SP_BajaTerminal");
                datos.AgregarParametro("@Id", idTerminal);

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



        public void modificarTerminal(Terminal terminal)
        {
            AccesoDatos datos = new AccesoDatos();
            SqlCommand comando = new SqlCommand();
            try
            {
                //datos.setearQuery("Update POKEMONS set Nombre=@Nombre Where Id=@Id");
                datos.setearSP("SP_ModificarTerminal");
                datos.AgregarParametro("@Id", terminal.IdTerminal.ToString());
                datos.AgregarParametro("@CodTerminal", terminal.CodTerminal.ToString());
                datos.AgregarParametro("@NomTerminal", terminal.NombreTerminal);
                datos.AgregarParametro("@Estado", terminal.Estado);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
