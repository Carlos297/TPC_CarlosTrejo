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
    public partial class productos : System.Web.UI.Page
    {
        public List<Chofer> listaChoferes { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {




            try
            {
                ChoferNegocio negocio = new ChoferNegocio();
                listaChoferes = negocio.listar2();
                //dgvar = listaArticulos;
                //dgvPokemons.DataBind();

                Session[Session.SessionID + "listaChoferes"] = listaChoferes;

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


        


    }
}