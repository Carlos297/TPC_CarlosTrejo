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
        private Chofer chofer;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                txtID.Text = (string)Session["Id"];
                txtLegajo.Text = (string)Session["Legajo"];
                txtApellido.Text = (string)Session["Apellido"];
                txtNombre.Text = (string)Session["Nombre"];
                txtSexo.Text = (string)Session["Sexo"];
                txtFechaNac.Text = (string)Session["FechaNac"];
               // txtEstado.Text = (string)Session["Estado"];

            }

            

            
        }



        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            ChoferNegocio negocio = new ChoferNegocio();
            try
            {

                
                chofer = new Chofer();

                chofer.IdChofer = int.Parse(txtID.Text.Trim());
                chofer.Legajo = int.Parse(txtLegajo.Text.Trim());
                chofer.Apellido = txtApellido.Text.Trim();
                chofer.Nombre = txtNombre.Text.Trim();
                chofer.Sexo = txtSexo.Text.Trim();
                chofer.FechaNacimiento = DateTime.Parse(txtFechaNac.Text.ToString()); 
                chofer.Estado = "A";

                //if (chofer.IdChofer == 0)
                negocio.modificarChofer(chofer);


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

