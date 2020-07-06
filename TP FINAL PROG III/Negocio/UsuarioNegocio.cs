using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using Negocio;

namespace Negocio
{
    public class UsuarioNegocio
    {



        public List<Usuario> lista;

        public List<Usuario> listar2()
        {
            lista = new List<Usuario>();
            Usuario aux;

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearQery("Select ID, CodUsuario, TipoUsuario, Email, Sexo, FechaReg, FechaNac, Clave, Estado from Usuarios where Estado = 'A'");

                datos.ejecutarLector();

                while (datos.lector.Read())
                {
                    aux = new Usuario();

                    //aux.Nombre = (string)lector["nombre"]; OTRA FORMA DE ASIGNACION

                    aux.IdUsuario = datos.lector.GetInt32(0);

                    if (!Convert.IsDBNull(datos.lector["CodUsuario"]))
                        aux.CodUsuario = datos.lector.GetString(1);

                    if (!Convert.IsDBNull(datos.lector["TipoUsuario"]))
                        aux.TipoUsuario = datos.lector.GetString(2);

                    if (!Convert.IsDBNull(datos.lector["Email"]))
                        aux.Email = datos.lector.GetString(3);

                    if (!Convert.IsDBNull(datos.lector["Sexo"]))
                        aux.Sexo = datos.lector.GetString(4);

                    if (!Convert.IsDBNull(datos.lector["FechaReg"]))
                        aux.FechaReg = datos.lector.GetDateTime(5);

                    if (!Convert.IsDBNull(datos.lector["FechaNac"]))
                        aux.FechaNac = datos.lector.GetDateTime(6);

                    if (!Convert.IsDBNull(datos.lector["Clave"]))
                        aux.Clave = datos.lector.GetString(7);

                    if (!Convert.IsDBNull(datos.lector["Estado"]))
                        aux.Estado = datos.lector.GetString(8);

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



        public void agregar(Usuario nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();




            try
            {

                conexion.ConnectionString = "data source=localhost\\sqlexpress; initial catalog=TP_Final; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "insert into Usuarios (CodUsuario, TipoUsuario, Email, Sexo, FechaReg, FechaNac, Estado, Clave) Values (@CodUsuario, @TipoUsuario, @Email, @Sexo, @FechaReg, @FechaNac, @Estado, @Clave)";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@CodUsuario", nuevo.CodUsuario.ToString());
                comando.Parameters.AddWithValue("@TipoUsuario", nuevo.TipoUsuario.ToString());
                comando.Parameters.AddWithValue("@Email", nuevo.Email.ToString());
                comando.Parameters.AddWithValue("@Sexo", nuevo.Sexo.ToString());
                comando.Parameters.AddWithValue("@FechaReg", nuevo.FechaReg);
                comando.Parameters.AddWithValue("@FechaNac", nuevo.FechaNac);
                comando.Parameters.AddWithValue("@Estado", nuevo.Estado);
                comando.Parameters.AddWithValue("@Clave", nuevo.Clave.ToString());

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



        public void bajaUsuario(string idUsuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                //SqlCommand cmd = new SqlCommand();
                datos.setearSP("SP_BajaUsuario");
                datos.AgregarParametro("@Id", idUsuario);

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



        public void modificarUsuario(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();
            SqlCommand comando = new SqlCommand();
            try
            {
                //datos.setearQuery("Update POKEMONS set Nombre=@Nombre Where Id=@Id");
                datos.setearSP("SP_ModificarUsuario");
                datos.AgregarParametro("@Id", usuario.IdUsuario.ToString());
                datos.AgregarParametro("@CodUsuario", usuario.CodUsuario.ToString());
                datos.AgregarParametro("@TipoUsuario", usuario.TipoUsuario);
                datos.AgregarParametro("@Email", usuario.Email);
                datos.AgregarParametro("@Sexo", usuario.Sexo);
                datos.AgregarParametroFecha("@FechaReg", usuario.FechaReg);
                datos.AgregarParametroFecha("@FechaNac", usuario.FechaNac);
                //datos.AgregarParametro("@FechaNac", chofer.FechaNacimiento);
                datos.AgregarParametro("@Estado", usuario.Estado);
                datos.AgregarParametro("@Clave", usuario.Clave);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




    }
}
