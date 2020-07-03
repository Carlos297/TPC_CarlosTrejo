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
    public partial class ModificarTerminal : System.Web.UI.Page
    {
        private Terminal terminal;
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
            TerminalNegocio negocio = new TerminalNegocio();
            try
            {


                terminal = new Terminal();

                terminal.IdTerminal = int.Parse(txtID.Text.Trim());
                terminal.CodTerminal = txtCodTerminal.Text.Trim();
                terminal.NombreTerminal = txtNomTerminal.Text.Trim();
                terminal.Estado = "A";

                //if (chofer.IdChofer == 0)
                negocio.modificarTerminal(terminal);


                Response.Redirect("Terminales.aspx");


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