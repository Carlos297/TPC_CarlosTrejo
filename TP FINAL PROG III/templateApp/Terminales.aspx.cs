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
    public partial class Terminales : System.Web.UI.Page
    {
        public List<Terminal> listaTerminales { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                TerminalNegocio negocio = new TerminalNegocio();
                listaTerminales = negocio.listar2();
                dgvTerminales.DataSource = listaTerminales;
                dgvTerminales.DataBind();

                Session[Session.SessionID + "listaTerminales"] = listaTerminales;

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

        protected void dgvTerminales_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["Id"] = dgvTerminales.SelectedRow.Cells[1].Text;
            Session["CodTerminal"] = dgvTerminales.SelectedRow.Cells[2].Text;
            Session["NomTerminal"] = dgvTerminales.SelectedRow.Cells[3].Text;
            Session["Estado"] = dgvTerminales.SelectedRow.Cells[4].Text;
            Response.Redirect("ModificarTerminal.aspx");

        }

        protected void dgvTerminales_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Eliminar")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                string idTerminal = dgvTerminales.Rows[index].Cells[1].Text;
                TerminalNegocio negocio = new TerminalNegocio();
                negocio.bajaTerminal(idTerminal);
                Response.Redirect("Terminales.aspx");
            }



            //if(e.CommandName == "Modificar")
            //{
            //    Response.Redirect("NuevoChofer.aspx");

            //    //int index = Convert.ToInt32(e.CommandArgument);
            //    //Chofer chofer = new Chofer();
            //    //chofer = (Chofer)dgvChoferes.Rows.Cast;
            //}


        }



        protected void dgvTerminales_RowEditing(object sender, GridViewEditEventArgs e)
        {
        }

        protected void dgvTerminales_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void dgvTerminales_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
        }
    }
}