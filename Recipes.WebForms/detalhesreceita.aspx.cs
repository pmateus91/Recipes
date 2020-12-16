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
        Recipe recipe = new Recipe();
        DataTable dt = new DataTable();
        int id;


        protected void Page_Load(object sender, EventArgs e)
        {
            _service = new Recipes_Services();
            _riService = new RecipesIngredients_Services();

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

        }
        private void CreateDataTable()
        {           
                dt.Columns.Add("Ingrediente");
                dt.Columns.Add("Quantidade");
                dt.Columns.Add("Unidade");           
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

