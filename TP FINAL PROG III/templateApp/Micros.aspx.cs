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
    public partial class Micros : System.Web.UI.Page
    {
        public List<Micro> listaMicros { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                MicroNegocio negocio = new MicroNegocio();
                listaMicros = negocio.listar2();
                dgvMicros.DataSource = listaMicros;
                dgvMicros.DataBind();

                Session[Session.SessionID + "listaMicros"] = listaMicros;

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

        

        protected void dgvMicros_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["Id"] = dgvMicros.SelectedRow.Cells[1].Text;
            Session["Patente"] = dgvMicros.SelectedRow.Cells[2].Text;
            Session["Modelo"] = dgvMicros.SelectedRow.Cells[3].Text;
            Session["FechaFabr"] = dgvMicros.SelectedRow.Cells[4].Text;
            Session["CantAsientos"] = dgvMicros.SelectedRow.Cells[5].Text;
            Session["Estado"] = dgvMicros.SelectedRow.Cells[6].Text;
            Response.Redirect("ModificarMicro.aspx");

        }

        protected void dgvMicros_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Eliminar")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                string idMicro = dgvMicros.Rows[index].Cells[1].Text;
                MicroNegocio negocio = new MicroNegocio();
                negocio.bajaMicro(idMicro);
                Response.Redirect("Micros.aspx");
            }



            //if(e.CommandName == "Modificar")
            //{
            //    Response.Redirect("NuevoChofer.aspx");

            //    //int index = Convert.ToInt32(e.CommandArgument);
            //    //Chofer chofer = new Chofer();
            //    //chofer = (Chofer)dgvChoferes.Rows.Cast;
            //}


        }




        protected void dgvMicros_RowEditing(object sender, GridViewEditEventArgs e)
        {
        }

        protected void dgvMicros_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void dgvMicros_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
        }


    }
}