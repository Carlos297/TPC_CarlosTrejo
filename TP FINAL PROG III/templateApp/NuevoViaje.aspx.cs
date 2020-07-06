using Negocio;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace templateApp
{
    public partial class NuevoViaje : System.Web.UI.Page

    {
        private Viaje viaje;



        ChoferNegocio negocio = new ChoferNegocio();
        MicroNegocio negocioMicro = new MicroNegocio();
        TerminalNegocio negocioTerminal = new TerminalNegocio();
        TerminalDestinoNegocio negocioTerminalDestino = new TerminalDestinoNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Chofer> listaChofer = negocio.listar2();
                ddlChoferes.DataSource = listaChofer;
                ddlChoferes.DataTextField = "Apellido";
                ddlChoferes.DataValueField = "IdChofer";
                ddlChoferes.DataBind();


                List<Micro> listaMicro = negocioMicro.listar2();
                ddlMicros.DataSource = listaMicro;
                ddlMicros.DataTextField = "Patente";
                ddlMicros.DataValueField = "IdMicro";
                ddlMicros.DataBind();


                List<Terminal> listaTerminalOrigen = negocioTerminal.listar2();
                ddlTerminalOrigen.DataSource = listaTerminalOrigen;
                ddlTerminalOrigen.DataTextField = "NombreTerminal";
                ddlTerminalOrigen.DataValueField = "IdTerminal";
                ddlTerminalOrigen.DataBind();


                List<TerminalDestino> listaTerminalDestino = negocioTerminalDestino.listar2();
                ddlTerminalDestino.DataSource = listaTerminalDestino;
                ddlTerminalDestino.DataTextField = "NombreTerminal";
                ddlTerminalDestino.DataValueField = "IdTerminal";
                ddlTerminalDestino.DataBind();




            }
        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {

            ViajeNegocio negocio = new ViajeNegocio();
            try
            {
               
                viaje = new Viaje();

                viaje.CodViaje = txtCodViaje.Text.Trim();
                viaje.Chofer = new Chofer();
                viaje.Chofer.IdChofer = int.Parse(ddlChoferes.SelectedValue);
                viaje.Micro = new Micro();
                viaje.Micro.IdMicro = int.Parse(ddlMicros.SelectedValue);
                viaje.TerminalOrigen = new Terminal();
                viaje.TerminalOrigen.IdTerminal = int.Parse(ddlTerminalOrigen.SelectedValue);
                viaje.TerminalDestino = new TerminalDestino();
                viaje.TerminalDestino.IdTerminal = int.Parse(ddlTerminalDestino.SelectedValue);
                viaje.FechaViaje = DateTime.Parse(txtFechaViaje.Text.ToString());
                viaje.Costo = Decimal.Parse(txtPrecio.Text);
                //chofer.Estado = txtEstado.Text.Trim();
              
                if (viaje.IdVIajes == 0)
                    negocio.agregar(viaje);


                Response.Redirect("Viajes.aspx");


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