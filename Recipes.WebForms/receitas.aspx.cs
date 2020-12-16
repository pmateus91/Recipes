using Recipes.Model.Model;
using PMLibrary;
using Recipes.Services.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Recipes.WebForms
{
    public partial class Receitas : System.Web.UI.Page
    {
        private Recipes_Services _service;
        public Categories_Services _cService;

        public Recipe recipe = new Recipe();
        public Category category = new Category();

        protected void Page_Load(object sender, EventArgs e)
        {
            _service = new Recipes_Services();
            this.rptRecipe.DataSource = _service.GetALLValidated();
            
            this.rptRecipe.DataBind();
        }

        protected void VerReceita(object sender, EventArgs e)
        {
            Session["ID"] = (sender as LinkButton).CommandArgument;
            Response.Redirect("~/detalhesreceita.aspx");
        }
    }

}