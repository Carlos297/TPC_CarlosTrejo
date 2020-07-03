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
    public partial class usuarios : System.Web.UI.Page
    {
        public List<Usuario> listaUsuarios { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                UsuarioNegocio negocio = new UsuarioNegocio();
                listaUsuarios = negocio.listar2();
                dgvUsuarios.DataSource = listaUsuarios;
                dgvUsuarios.DataBind();

                Session[Session.SessionID + "listaUsuarios"] = listaUsuarios;

                //cboti.DataSource = listaPokemons;
                //cboPokemons.DataBind();


                //cboPokemons.Items.Add("Rojo");
                //cboPokemons.Items.Add("Azul");
                //cboPokemons.Items.Add("Verde");

                if (!IsPostBack)
                { //pregunto si es la primera carga de la page
                    //txtNumeroPokemon.Text = "150";
                    //cbotipoArt.DataSource = listaArticulos;
                    //cbotipoArt.DataBind();

                    //esto es lo que necesitamos para el repeater.
                    //repetidor.DataSource = listaPokemons;
                    //repetidor.DataBind();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        protected void dgvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["Id"] = dgvUsuarios.SelectedRow.Cells[1].Text;
            Session["CodUsuario"] = dgvUsuarios.SelectedRow.Cells[2].Text;
            Session["TipoUsuario"] = dgvUsuarios.SelectedRow.Cells[3].Text;
            Session["Email"] = dgvUsuarios.SelectedRow.Cells[4].Text;
            Session["Sexo"] = dgvUsuarios.SelectedRow.Cells[5].Text;
            Session["FechaReg"] = dgvUsuarios.SelectedRow.Cells[6].Text;
            Session["FechaNac"] = dgvUsuarios.SelectedRow.Cells[7].Text;
            Session["Estado"] = dgvUsuarios.SelectedRow.Cells[8].Text;
            Session["Clave"] = dgvUsuarios.SelectedRow.Cells[9].Text;
            Response.Redirect("ModificarUsuario.aspx");

        }

        protected void dgvUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Eliminar")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                string idUsuario = dgvUsuarios.Rows[index].Cells[1].Text;
                UsuarioNegocio negocio = new UsuarioNegocio();
                negocio.bajaUsuario(idUsuario);
                Response.Redirect("Usuarios.aspx");
            }



            //if(e.CommandName == "Modificar")
            //{
            //    Response.Redirect("NuevoChofer.aspx");

            //    //int index = Convert.ToInt32(e.CommandArgument);
            //    //Chofer chofer = new Chofer();
            //    //chofer = (Chofer)dgvChoferes.Rows.Cast;
            //}


        }



        protected void dgvUsuarios_RowEditing(object sender, GridViewEditEventArgs e)
        {
        }

        protected void dgvUsuarios_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void dgvUsuarios_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
        }

    }
}