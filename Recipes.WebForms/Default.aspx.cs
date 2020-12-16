using Recipes.Model.Model;
using Recipes.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Recipes.WebForms
{
    public partial class Default : System.Web.UI.Page
    {

        private Categories_Services _service;
        public List<Category> categories;
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            _service = new Categories_Services();
            this.rptCategory.DataSource = _service.GetALL();
            this.rptCategory.DataBind();
        }
        protected void VerReceita(object sender, EventArgs e)
        {
            Session["ID"] = (sender as LinkButton).CommandArgument;
            id = int.Parse(Session["ID"].ToString());
            if (id == 1)
            {
                Response.Redirect("~/Categorias/entradas-petiscos.aspx");
            }
            else if (id == 2) 
            {
                Response.Redirect("~/Categorias/sopa.aspx");
            }
            else if (id == 3)
            {
                Response.Redirect("~/Categorias/carne.aspx");
            }
            else if (id == 4)
            {
                Response.Redirect("~/Categorias/peixe.aspx");
            }
            else if (id == 5)
            {
                Response.Redirect("~/Categorias/salada.aspx");
            }
            else if (id == 6)
            {
                Response.Redirect("~/Categorias/acompanhamentos.aspx");
            }
            else if (id == 7)
            {
                Response.Redirect("~/Categorias/doces-sobremesas.aspx");
            }
            else if (id == 8)
            {
                Response.Redirect("~/Categorias/vegetariano-vegan.aspx");
            }
        }
        protected void Page_PreInit(object sender, EventArgs e)
        {
            this.MasterPageFile = "~/Site.Master";
        }       
    }
}