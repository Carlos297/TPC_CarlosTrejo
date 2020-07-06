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
    public partial class SacarPasajes : System.Web.UI.Page
    {
        private Pasaje pasaje;

        ViajeNegocio negocio = new ViajeNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                List<Viaje> listaViaje = negocio.listar2();
                ddlViajes.DataSource = listaViaje;
                ddlViajes.DataTextField = "CodViaje";
                ddlViajes.DataValueField = "IdViajes";
                ddlViajes.DataBind();
                


            }

        }


        public void btnGuardar_Click(object sender, EventArgs e)
        {

            PasajeNegocio negocio = new PasajeNegocio();
            try
            {

                pasaje = new Pasaje();

                pasaje.CodBoleto = txtCodBoleto.Text.Trim();
                pasaje.Viaje = new Viaje();
                pasaje.Viaje.IdVIajes = int.Parse(ddlViajes.SelectedValue);
               
                pasaje.CantBoletos = int.Parse(txtCantBoletos.Text);
                var cantbol = int.Parse(txtCantBoletos.Text);
                var costoViaje = pasaje.Viaje.Costo;
                pasaje.PrecioTotal = cantbol*costoViaje;
                //chofer.Estado = txtEstado.Text.Trim();
                
                if (pasaje.IdBoleto == 0)
                    negocio.agregar(pasaje);


                Response.Redirect("Pasajes.aspx");


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