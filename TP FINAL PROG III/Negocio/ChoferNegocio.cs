using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

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
                datos.SetearQery("Select ID, Legajo, Apellidos, Nombres from Choferes");

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

                    //if (!Convert.IsDBNull(datos.lector["Sexo"]))
                    //    aux.Sexo = datos.lector.GetChar(4);

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



    }
}
