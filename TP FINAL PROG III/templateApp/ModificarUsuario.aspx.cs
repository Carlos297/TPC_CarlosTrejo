using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace templateApp
{
    public partial class ModificarUsuario : System.Web.UI.Page
    {
        private Usuario usuario;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                txtIDUsuario.Text = (string)Session["Id"];
                txtCodUsuario.Text = (string)Session["CodUsuario"];
                txtTipoUsuario.Text = (string)Session["TipoUsuario"];
                txtEmail.Text = (string)Session["Email"];
                txtSexo.Text = (string)Session["Sexo"];
                txtFechaReg.Text = (string)Session["FechaReg"];
                txtFechaNac.Text = (string)Session["FechaNac"];
                txtClave.Text = (string)Session["Clave"];
                // txtEstado.Text = (string)Session["Estado"];

            }

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            UsuarioNegocio negocio = new UsuarioNegocio();
            try
            {


                usuario = new Usuario();

                usuario.IdUsuario = int.Parse(txtIDUsuario.Text.Trim());
                usuario.CodUsuario = txtCodUsuario.Text.Trim();
                usuario.TipoUsuario = txtTipoUsuario.Text.Trim();
                usuario.Email = txtEmail.Text.Trim();
                usuario.Sexo = txtSexo.Text.Trim();
                usuario.FechaReg = DateTime.Parse(txtFechaReg.Text.ToString());
                usuario.FechaNac = DateTime.Parse(txtFechaNac.Text.ToString());
                usuario.Clave = txtClave.Text.Trim();
                usuario.Estado = "A";

                //if (chofer.IdChofer == 0)
                negocio.modificarUsuario(usuario);


                Response.Redirect("Usuarios.aspx");


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