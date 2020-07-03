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
    public partial class NuevoUsuario : System.Web.UI.Page
    {
        private Usuario usuario
            ;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {

            UsuarioNegocio negocio = new UsuarioNegocio();
            try
            {
                if (usuario == null)
                    usuario = new Usuario();

                usuario.CodUsuario = txtCodUsuario.Text.Trim();
                usuario.TipoUsuario = txtTipoUsuario.Text.Trim();
                usuario.Email = txtEmail.Text.Trim();
                usuario.Sexo = txtSexo.Text.Trim();
                usuario.FechaReg = DateTime.Parse(txtFechaReg.Text.ToString());
                usuario.FechaNac = DateTime.Parse(txtFechaNac.Text.ToString());
                usuario.Clave = txtClave.Text.Trim();
                //chofer.Estado = txtEstado.Text.Trim();
                usuario.Estado = "A";

                if (usuario.IdUsuario == 0)
                    negocio.agregar(usuario);


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