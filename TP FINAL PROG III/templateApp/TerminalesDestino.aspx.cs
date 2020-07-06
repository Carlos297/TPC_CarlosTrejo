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
    public partial class TerminalesDestino : System.Web.UI.Page
    {
        public List<TerminalDestino> listaTerminalesDestino { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                TerminalDestinoNegocio negocio = new TerminalDestinoNegocio();
                listaTerminalesDestino = negocio.listar2();
                dgvTerminalesDestino.DataSource = listaTerminalesDestino;
                dgvTerminalesDestino.DataBind();

                Session[Session.SessionID + "listaTerminalesDestino"] = listaTerminalesDestino;

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

        protected void dgvTerminalesDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["Id"] = dgvTerminalesDestino.SelectedRow.Cells[1].Text;
            Session["CodTerminal"] = dgvTerminalesDestino.SelectedRow.Cells[2].Text;
            Session["NomTerminal"] = dgvTerminalesDestino.SelectedRow.Cells[3].Text;
            Session["Estado"] = dgvTerminalesDestino.SelectedRow.Cells[4].Text;
            Response.Redirect("ModificarTerminalDestino.aspx");

        }

        protected void dgvTerminalesDestino_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Eliminar")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                string idTerminal = dgvTerminalesDestino.Rows[index].Cells[1].Text;
                TerminalDestinoNegocio negocio = new TerminalDestinoNegocio();
                negocio.bajaTerminal(idTerminal);
                Response.Redirect("TerminalesDestino.aspx");
            }



            //if(e.CommandName == "Modificar")
            //{
            //    Response.Redirect("NuevoChofer.aspx");

            //    //int index = Convert.ToInt32(e.CommandArgument);
            //    //Chofer chofer = new Chofer();
            //    //chofer = (Chofer)dgvChoferes.Rows.Cast;
            //}


        }



        protected void dgvTerminalesDestino_RowEditing(object sender, GridViewEditEventArgs e)
        {
        }

        protected void dgvTerminalesDestino_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void dgvTerminalesDestino_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
        }
    }
}