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
                dgvChoferes.DataSource = listaChoferes;
                dgvChoferes.DataBind();

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
        

        protected void dgvChoferes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["Id"] = dgvChoferes.SelectedRow.Cells[1].Text;
            Session["Legajo"] = dgvChoferes.SelectedRow.Cells[2].Text;
            Session["Nombre"] = dgvChoferes.SelectedRow.Cells[3].Text;
            Session["Apellido"] = dgvChoferes.SelectedRow.Cells[4].Text;
            Session["Sexo"] = dgvChoferes.SelectedRow.Cells[5].Text;
            Session["FechaNac"] = dgvChoferes.SelectedRow.Cells[6].Text;
            Session["Estado"] = dgvChoferes.SelectedRow.Cells[7].Text;
            Response.Redirect("ModificarChofer.aspx");

        }

        protected void dgvChoferes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
                if(e.CommandName == "Eliminar") {
                int index = Convert.ToInt32(e.CommandArgument);
                string idChofer = dgvChoferes.Rows[index].Cells[1].Text;
                ChoferNegocio negocio = new ChoferNegocio();
                negocio.bajaChofer(idChofer);
                Response.Redirect("Choferes.aspx");
            }
                
            

            //if(e.CommandName == "Modificar")
            //{
            //    Response.Redirect("NuevoChofer.aspx");

            //    //int index = Convert.ToInt32(e.CommandArgument);
            //    //Chofer chofer = new Chofer();
            //    //chofer = (Chofer)dgvChoferes.Rows.Cast;
            //}


        }



        protected void dgvChoferes_RowEditing(object sender, GridViewEditEventArgs e)
        {       
        }

        protected void dgvChoferes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void dgvChoferes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
        }
    }



}