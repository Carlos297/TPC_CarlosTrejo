using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace templateApp
{  
    public partial class NuevoChofer : System.Web.UI.Page
    {
        private Chofer chofer;
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }


        public void btnGuardar_Click(object sender, EventArgs e)
        {

            ChoferNegocio negocio = new ChoferNegocio();
            try
            {
                //if (chofer == null)
                chofer = new Chofer();

                chofer.Legajo = int.Parse(txtLegajo.Text.Trim());
                chofer.Nombre = txtNombre.Text.Trim();
                chofer.Apellido = txtAApellido.Text.Trim();
                chofer.Sexo = txtSexo.Text.Trim();
                chofer.FechaNacimiento = DateTime.Parse(txtFechaNac.Text);
                chofer.Estado = txtEstado.Text.Trim();

                //if (chofer.IdChofer == 0)
                negocio.agregar(chofer);

                //else
                //    negocio.modificar(articulo);

                //Dispose();

            }
            catch (Exception EX)
            {

                throw EX;
            }
        }



    }





}




