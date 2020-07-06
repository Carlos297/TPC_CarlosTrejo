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
    public partial class ModificarTerminalDestino : System.Web.UI.Page
    {
        private TerminalDestino terminalDestino;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                txtID.Text = (string)Session["Id"];
                txtCodTerminal.Text = (string)Session["CodTerminal"];
                txtNomTerminal.Text = (string)Session["NomTerminal"];
                // txtEstado.Text = (string)Session["Estado"];

            }

        }
        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            TerminalDestinoNegocio negocio = new TerminalDestinoNegocio();
            try
            {


                terminalDestino = new TerminalDestino();

                terminalDestino.IdTerminal = int.Parse(txtID.Text.Trim());
                terminalDestino.CodTerminal = txtCodTerminal.Text.Trim();
                terminalDestino.NombreTerminal = txtNomTerminal.Text.Trim();
                terminalDestino.Estado = "A";

                //if (chofer.IdChofer == 0)
                negocio.modificarTerminal(terminalDestino);


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