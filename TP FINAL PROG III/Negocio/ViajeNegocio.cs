using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;
using System.Data.SqlClient;

namespace Negocio
{
    public class ViajeNegocio
    {
        public List<Viaje> lista;

        public List<Viaje> listar2()
        {
            lista = new List<Viaje>();
            Viaje aux;

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearQery("select V.ID, V.CodViaje, D.NomTerminal as NombreDestino, O.NomTerminal as NombreOrigen, C.Legajo LegajoChofer, C.Apellidos, M.Patente, V.FechaViaje, V.Precio from Viajes V inner join Choferes C on V.IdChofer = C.ID inner join Micros M on V.IdMicro = M.ID inner join TerminalesOrigen O on V.IdTerminalOrigen = O.ID inner join TerminalesDestino D on V.IdTerminalDestino = D.ID");

                datos.ejecutarLector();

                while (datos.lector.Read())
                {
                    aux = new Viaje();

                    //aux.Nombre = (string)lector["nombre"]; OTRA FORMA DE ASIGNACION

                    aux.IdVIajes = datos.lector.GetInt32(0);

                    aux.CodViaje = datos.lector.GetString(1);

                    aux.TerminalDestino = new TerminalDestino();
                    aux.TerminalDestino.NombreTerminal = datos.lector.GetString(2);
                    aux.TerminalOrigen = new Terminal();
                    aux.TerminalOrigen.NombreTerminal = datos.lector.GetString(3);
                  

                    aux.Chofer = new Chofer();

                    //if (!Convert.IsDBNull(datos.lector["LegajoChofer"]))
                    aux.Chofer.Legajo = datos.lector.GetInt32(4);
                    aux.Chofer.Apellido = datos.lector.GetString(5);

                    aux.Micro = new Micro();
                    aux.Micro.Patente = datos.lector.GetString(6);

                    aux.FechaViaje = datos.lector.GetDateTime(7);

                   
                    //if (!Convert.IsDBNull(datos.lector["Estado"]))
                        aux.Costo = datos.lector.GetDecimal(8);

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

        public void agregar(Viaje nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();




            try
            {

                conexion.ConnectionString = "data source=localhost\\sqlexpress; initial catalog=TP_Final; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "insert into Viajes (CodViaje, IdChofer, IdMicro, IdTerminalOrigen, IdTerminalDestino, FechaVIaje, Precio) Values (@CodViaje, @IdChofer, @IdMicro, @IdTerminalOrigen, @IdTerminalDestino, @FechaVIaje, @Precio)";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@CodViaje", nuevo.CodViaje.ToString());
                comando.Parameters.AddWithValue("@IdChofer", nuevo.Chofer.IdChofer.ToString());
                comando.Parameters.AddWithValue("@IdMicro", nuevo.Micro.IdMicro.ToString());
                comando.Parameters.AddWithValue("@IdTerminalOrigen", nuevo.TerminalOrigen.IdTerminal.ToString());
                comando.Parameters.AddWithValue("@IdTerminalDestino", nuevo.TerminalDestino.IdTerminal);
                comando.Parameters.AddWithValue("@FechaVIaje", nuevo.FechaViaje);
                comando.Parameters.AddWithValue("@Precio", nuevo.Costo.ToString());

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

    }
}
