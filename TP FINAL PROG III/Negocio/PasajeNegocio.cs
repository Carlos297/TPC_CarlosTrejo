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
    public class PasajeNegocio
    {
        public List<Pasaje> lista;

        public List<Pasaje> listar2()
        {
            lista = new List<Pasaje>();
            Pasaje aux;

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearQery("select P.ID, P.CodBoleto, V.CodViaje, V.Precio, P.CantBoletos, P.TotalPrecio from Pasajes P inner join Viajes V on P.IdViaje=V.ID");

                datos.ejecutarLector();

                while (datos.lector.Read())
                {
                    aux = new Pasaje();

                    //aux.Nombre = (string)lector["nombre"]; OTRA FORMA DE ASIGNACION

                    aux.IdBoleto = datos.lector.GetInt32(0);

                    aux.CodBoleto = datos.lector.GetString(1);

                    aux.Viaje = new Viaje();
                    aux.Viaje.CodViaje = datos.lector.GetString(2);
                    aux.Viaje.Costo = datos.lector.GetDecimal(3);


                    aux.CantBoletos = datos.lector.GetInt32(4);
                    aux.PrecioTotal = datos.lector.GetDecimal(5);

                    //if (!Convert.IsDBNull(datos.lector["Estado"]))
                   

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

        public void agregar(Pasaje nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();




            try
            {

                conexion.ConnectionString = "data source=localhost\\sqlexpress; initial catalog=TP_Final; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "insert into Pasajes (CodBoleto, IdViaje, CantBoletos, TotalPrecio) Values (@CodBoleto, @IdViaje, @CantBoletos, @TotalPrecio)";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@CodBoleto", nuevo.CodBoleto.ToString());
                comando.Parameters.AddWithValue("@IdViaje", nuevo.Viaje.IdVIajes.ToString());
                comando.Parameters.AddWithValue("@CantBoletos", nuevo.CantBoletos.ToString()); 
                comando.Parameters.AddWithValue("@TotalPrecio", nuevo.PrecioTotal.ToString());

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
