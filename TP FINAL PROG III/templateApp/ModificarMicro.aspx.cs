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
    public partial class ModificarMicro : System.Web.UI.Page

    {
        private Micro micro;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                txtID.Text = (string)Session["Id"];
                txtPatente.Text = (string)Session["Patente"];
                txtModelo.Text = (string)Session["Modelo"];
                txtFechaFabr.Text = (string)Session["FechaFabr"];
                txtCantAsientos.Text = (string)Session["CantAsientos"];
               // txtEstado.Text = (string)Session["Estado"];
               
              
            }

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            MicroNegocio negocio = new MicroNegocio();
            try
            {


                micro = new Micro();

                micro.IdMicro = int.Parse(txtID.Text.Trim());
                micro.Patente = txtPatente.Text.Trim();
                micro.Modelo = int.Parse(txtModelo.Text.Trim());
                micro.FechaFabricacion = DateTime.Parse(txtFechaFabr.Text.ToString());
                micro.CantAsientos = int.Parse(txtCantAsientos.Text.Trim());
                micro.Estado = "A";

                //if (chofer.IdChofer == 0)
                negocio.modificarMicro(micro);


                Response.Redirect("Micros.aspx");


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