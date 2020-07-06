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
    public partial class Pasajes : System.Web.UI.Page
    {
        public List<Pasaje> listaPasajes { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {


            try
            {
                PasajeNegocio negocio = new PasajeNegocio();
                listaPasajes = negocio.listar2();
                dgvPasajes.DataSource = listaPasajes;
                dgvPasajes.DataBind();

                Session[Session.SessionID + "listaPasajes"] = listaPasajes;

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



        protected void dgvPasajes_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        protected void dgvPasajes_RowCommand(object sender, GridViewCommandEventArgs e)
        {




            //if(e.CommandName == "Modificar")
            //{
            //    Response.Redirect("NuevoChofer.aspx");

            //    //int index = Convert.ToInt32(e.CommandArgument);
            //    //Chofer chofer = new Chofer();
            //    //chofer = (Chofer)dgvChoferes.Rows.Cast;
            //}


        }



        protected void dgvPasajes_RowEditing(object sender, GridViewEditEventArgs e)
        {
        }

        protected void dgvPasajes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void dgvPasajes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
        }

    }
}