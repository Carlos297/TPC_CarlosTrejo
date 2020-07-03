using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    public class AccesoDatos
    {
        public SqlDataReader lector { get; set; }
        public SqlConnection conexion { get; }
        public SqlCommand comando { get; set; }

        public AccesoDatos()
        {

            conexion = new SqlConnection("data source=localhost\\sqlexpress; initial catalog=TP_Final; integrated security=sspi");
            comando = new SqlCommand();
            comando.Connection = conexion;
        }

        public void SetearQery(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;


        }

        public void setearSP(string sp)
        {
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = sp;

        }

        public void AgregarParametro(string parametro, string valor)
        {
            
                comando.Parameters.AddWithValue(parametro, valor);
            

        }

        public void AgregarParametroFecha(string parametro, DateTime valor)
        {

            comando.Parameters.AddWithValue(parametro, valor);


        }

        public void ejecutarLector()
        {
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ejecutarAccion()
        {
            try
            {
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

        public void cerrarConexion()
        {
            conexion.Close();
        }


    }
}
