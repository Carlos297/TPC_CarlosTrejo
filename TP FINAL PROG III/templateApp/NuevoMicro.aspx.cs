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
    public partial class NuevoMicro : System.Web.UI.Page
    {
        private Micro micro;

        protected void Page_Load(object sender, EventArgs e)
        {



        }


        public void btnGuardar_Click(object sender, EventArgs e)
        {

            MicroNegocio negocio = new MicroNegocio();
            try
            {
                if (micro == null)
                    micro = new Micro();

                micro.Patente = txtPatente.Text.Trim();
                micro.Modelo = int.Parse(txtModelo.Text.Trim());
                micro.FechaFabricacion = DateTime.Parse(txtFechaFabr.Text.ToString());
                micro.CantAsientos = int.Parse(txtCanAsientos.Text.Trim());
               
                //chofer.Estado = txtEstado.Text.Trim();
                micro.Estado = "A";

                if (micro.IdMicro == 0)
                    negocio.agregar(micro);


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