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
    public partial class InserirReceita : System.Web.UI.Page
    {
        private Recipes_Services _rService;
        private RecipesIngredients_Services _riService;
        private Categories_Services _cService;
        private Ingredients_Services _iService;
        private Users_Services _uService;
        DataTable dt = new DataTable();
        Recipe recipe = new Recipe();
        User user = new User();
        string _membershipUsername;
        int userId;
        protected void Page_Load(object sender, EventArgs e)
        {
            _rService = new Recipes_Services();
            _cService = new Categories_Services();
            _iService = new Ingredients_Services();
            _riService = new RecipesIngredients_Services();
            _uService = new Users_Services();
            FillComboBoxes();
            CreateDataTable();           
        }
        protected void btninsertIngredient_Click(object sender, EventArgs e)
        {
            InsertIngredients();
        }

        protected void gvIngredientsInsert_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[0].Visible = false;
        }


        protected void btnInsertRecibe_Click(object sender, EventArgs e)
        {
            
            double minutes = double.Parse(tbDuration.Text);
            _membershipUsername = User.Identity.Name;
            foreach (User user in _uService.GetALL())
            {
                if (_membershipUsername == user.MembershipUsername)
                {
                    userId = user.ID;                    
                }
            }
          
            recipe.Title = tbName.Text;
            recipe.CategoryID = int.Parse(cbCategory.SelectedValue);
            recipe.Difficulty = (Difficulty)cbDifficulty.SelectedIndex;
            recipe.Duration = TimeSpan.FromMinutes(minutes);
            recipe.Instructions = tbInstructions.Text;
            recipe.User = userId;

            _rService.Add(recipe);

            int id = recipe.ID;
            dt = (DataTable)ViewState["Records"];
            foreach (DataRow row in dt.Rows)
            {
                RecipeIngredient recipeIngredient = new RecipeIngredient();
                recipeIngredient.RecipeID = id;
                recipeIngredient.IngredientID = Convert.ToInt32(row["ID"].ToString());
                recipeIngredient.Quantity = Convert.ToDecimal(row["Quantidade"].ToString());
                recipeIngredient.Unit = row["Unidade"].ToString();
                _riService.Add(recipeIngredient);
            }
            Response.Redirect("~/asminhasreceitas.aspx");

        }
        private void InsertIngredients()
        {

            dt = (DataTable)ViewState["Records"];
            decimal quantity;
            decimal.TryParse(tbquantity.Text, out quantity);
            DataRow row = dt.NewRow();
            row["ID"] = cbIngredients.SelectedValue;
            row["Ingrediente"] = cbIngredients.SelectedItem;
            row["Quantidade"] = quantity;
            row["Unidade"] = cbUnity.SelectedItem;
            dt.Rows.Add(row);
            gvIngredientsInsert.DataSource = dt;
            gvIngredientsInsert.DataBind();

        }
        private void FillComboBoxes()
        {
            if (!Page.IsPostBack)
            {
                List<Ingredient> ingredients = _iService.GetALL();

                cbIngredients.DataSource = ingredients;
                cbIngredients.DataTextField = "Name";
                cbIngredients.DataValueField = "ID";
                cbIngredients.DataBind();

                List<Category> categories = _cService.GetALL();
                cbCategory.DataSource = categories;
                cbCategory.DataTextField = "Name";
                cbCategory.DataValueField = "ID";
                cbCategory.DataBind();

                foreach (var item in Enum.GetValues(typeof(Difficulty)))
                {
                    cbDifficulty.Items.Add(item.ToString());
                }
            }
        }

        private void CreateDataTable()
        {

            if (!Page.IsPostBack)
            {
                if (ViewState["Records"] == null)
                {
                    dt.Columns.Add("ID");
                    dt.Columns.Add("Ingrediente");
                    dt.Columns.Add("Quantidade");
                    dt.Columns.Add("Unidade");
                    ViewState["Records"] = dt;
                }
            }
        }
    }
}