using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace templateApp
{
    public partial class ModificarChofer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardarChoferModific_Click(object sender, EventArgs e)
        {
            ChoferNegocio negocio = new ChoferNegocio();
            try
            {
                
                //if (chofer == null)
                //    chofer = new Chofer();

                //chofer.Legajo = int.Parse(txtLegajo.Text.Trim());
                //chofer.Apellido = txtApellido.Text.Trim();
                //chofer.Nombre = txtNombre.Text.Trim();
                //chofer.Sexo = txtSexo.Text.Trim();
                //chofer.FechaNacimiento = DateTime.Parse(txtFechaNac.Text.ToString());
                //chofer.Estado = txtEstado.Text.Trim();

                //if (chofer.IdChofer == 0)
                //    negocio.agregar(chofer);


                Response.Redirect("Choferes.aspx");


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

