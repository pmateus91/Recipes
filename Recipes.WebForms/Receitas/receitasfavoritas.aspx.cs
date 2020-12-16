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
    public partial class Receitasfavoritas : System.Web.UI.Page
    {
       
        private Recipes_Services _service;
        private Users_Services _uService;
        private FavouriteRecipe_Services _frService;
        public Recipe recipe = new Recipe();
        string _membershipUsername;
        int id, userId;

        protected void Page_Load(object sender, EventArgs e)
        {
            _service = new Recipes_Services();
            _uService = new Users_Services();
            _frService = new FavouriteRecipe_Services();

            _membershipUsername = User.Identity.Name;
            foreach (User user in _uService.GetALL())
            {
                if (_membershipUsername == user.MembershipUsername)
                {
                    userId = user.ID;
                }
            }
            this.rptRecipe.DataSource = _service.GetALLFavourite(userId);
            this.rptRecipe.DataBind();
        }
        protected void VerReceita(object sender, EventArgs e)
        {
            Session["ID"] = (sender as LinkButton).CommandArgument;
            Response.Redirect("~/detalhesreceita.aspx");
        }
    
    }
}