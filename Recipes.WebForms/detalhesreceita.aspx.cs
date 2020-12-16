using PMLibrary;
using Recipes.Model.Model;
using Recipes.Model.Model.Utils;
using Recipes.Services.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Recipes.WebForms
{
    public partial class detalhesreceita : System.Web.UI.Page
    {
        private Recipes_Services _service;
        private RecipesIngredients_Services _riService;
        private FavouriteRecipe_Services _frService;
        private Users_Services _uService;
        Recipe recipe = new Recipe();
        User user = new User();
        FavouriteRecipe favouriteRecipe = new FavouriteRecipe();
        DataTable dt = new DataTable();
        int id, userId;
        string _membershipUsername;



        protected void Page_Load(object sender, EventArgs e)
        {
            _service = new Recipes_Services();
            _riService = new RecipesIngredients_Services();
            _frService = new FavouriteRecipe_Services();
            _uService = new Users_Services();

           

            if (!String.IsNullOrEmpty(Session["ID"].ToString()))
            {
                id = int.Parse(Session["ID"].ToString());
            }
            foreach (Recipe recipe in _service.GetByID(id))
            {
                lblTitle.Text = recipe.Title;
                lblCategoryName.Text = recipe.CategoryName.ToString();
                lblDuration.Text = TimeSpan.Parse(recipe.Duration.ToString()).TotalMinutes.ToString() + " Minutos";
                lblDifficulty.Text = recipe.Difficulty.ToString();
                lblRating.Text = recipe.Rating.ToString();
                lblUser.Text = recipe.UserName.ToString();
                lblInstructions.Text = recipe.Instructions.ToString();
                {

                }
                CreateDataTable();
                foreach (RecipeIngredient recipeIngredient in _riService.GetById(id))
                {
                    //dt = (DataTable)ViewState["Records"];
                    DataRow row = dt.NewRow();
                    row["Ingrediente"] = recipeIngredient.IngredientName;
                    row["Quantidade"] = recipeIngredient.Quantity;
                    row["Unidade"] = recipeIngredient.Unit;
                    dt.Rows.Add(row);
                    gvIngredientsInsert.DataSource = dt;
                    gvIngredientsInsert.DataBind();
                }


            }
            _membershipUsername = User.Identity.Name;
            foreach (User user in _uService.GetALL())
            {
                if (_membershipUsername == user.MembershipUsername)
                {
                    userId = user.ID;
                }
            }
            foreach (FavouriteRecipe favouriteRecipe in _frService.GetALL(userId))
            {
                if (favouriteRecipe.RecipeID == id)
                {
                    if (favouriteRecipe.IsFavourite == true)
                    {
                        btnFavoritos.Visible = false;
                    }
                    else
                    {
                        btnFavoritos.Visible = true;
                    }
                }
            }
        }
        private void CreateDataTable()
        {           
                dt.Columns.Add("Ingrediente");
                dt.Columns.Add("Quantidade");
                dt.Columns.Add("Unidade");           
        }

        protected void Favourite_Click(object sender, EventArgs e)
        {
            _membershipUsername = User.Identity.Name;
            foreach (User user in _uService.GetALL())
            {
                if (_membershipUsername == user.MembershipUsername)
                {
                    userId = user.ID;
                }
            }
            favouriteRecipe.UserID = userId;
            favouriteRecipe.RecipeID = id;
            favouriteRecipe.IsFavourite = true;
            _frService.Add(favouriteRecipe);
            Response.Redirect("~/receitas/receitasfavoritas.aspx");

        }
    }
}

