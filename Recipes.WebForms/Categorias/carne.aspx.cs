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
    public partial class Carne : System.Web.UI.Page
    {
      
        private Recipes_Services _service;
        public Recipe recipe = new Recipe();
        protected void Page_Load(object sender, EventArgs e)
        {
            _service = new Recipes_Services();

            this.rptRecipe.DataSource = _service.GetRecipeByCategoryID(3);
            this.rptRecipe.DataBind();
        }
        protected void VerReceita(object sender, EventArgs e)
        {
            Session["ID"] = (sender as LinkButton).CommandArgument;
            Response.Redirect("~/detalhesreceita.aspx");
        }
    }
}