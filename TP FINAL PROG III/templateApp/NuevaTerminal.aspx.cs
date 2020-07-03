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
    public partial class NuevaTerminal : System.Web.UI.Page
    {
        private Terminal terminal;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {

            TerminalNegocio negocio = new TerminalNegocio();
            try
            {
                if (terminal == null)
                    terminal = new Terminal();

                terminal.CodTerminal = txtCodTerminal.Text.Trim();
                terminal.NombreTerminal = txtNomTermianl.Text.Trim();
                //chofer.Estado = txtEstado.Text.Trim();
                terminal.Estado = "A";

                if (terminal.IdTerminal == 0)
                    negocio.agregar(terminal);


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