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
    public partial class Viajes : System.Web.UI.Page
    {
        public List<Viaje> listaViajes { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                ViajeNegocio negocio = new ViajeNegocio();
                listaViajes = negocio.listar2();
                dgvViajes.DataSource = listaViajes;
                dgvViajes.DataBind();

                Session[Session.SessionID + "listaViajes"] = listaViajes;

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

        protected void dgvViajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        protected void dgvViajes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
           



            //if(e.CommandName == "Modificar")
            //{
            //    Response.Redirect("NuevoChofer.aspx");

            //    //int index = Convert.ToInt32(e.CommandArgument);
            //    //Chofer chofer = new Chofer();
            //    //chofer = (Chofer)dgvChoferes.Rows.Cast;
            //}


        }



        protected void dgvViajes_RowEditing(object sender, GridViewEditEventArgs e)
        {
        }

        protected void dgvViajes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void dgvViajes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
        }
    }
}