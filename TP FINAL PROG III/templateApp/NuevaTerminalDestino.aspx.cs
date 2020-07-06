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
    public partial class NuevaTerminalDestino : System.Web.UI.Page
    {
        private TerminalDestino terminalDestino;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void btnGuardar_Click(object sender, EventArgs e)
        {

            TerminalDestinoNegocio negocio = new TerminalDestinoNegocio();
            try
            {
                if (terminalDestino == null)
                    terminalDestino = new TerminalDestino();

                terminalDestino.CodTerminal = txtCodTerminal.Text.Trim();
                terminalDestino.NombreTerminal = txtNomTermianl.Text.Trim();
                //chofer.Estado = txtEstado.Text.Trim();
                terminalDestino.Estado = "A";

                if (terminalDestino.IdTerminal == 0)
                    negocio.agregar(terminalDestino);


                Response.Redirect("TerminalesDestino.aspx");


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