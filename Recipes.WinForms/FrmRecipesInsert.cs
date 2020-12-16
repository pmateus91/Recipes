using PMLibrary;
using Recipes.Model.Model;
using Recipes.Model.Model.Utils;
using Recipes.Services.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Recipes.WinForms
{
    public partial class FrmRecipesInsert : Form
    {
        int _id,_categoryID,_ingredientID;

        private Recipes_Services _rService;
        private Categories_Services _cService;
        private Ingredients_Services _iService;
        private RecipesIngredients_Services _riService;
        Recipe recipe = new Recipe();

        DataTable dtInsertIngredients = new DataTable();
        public FrmRecipesInsert(bool isInsert, int id = 0)
        {
            InitializeComponent();
            _rService = new Recipes_Services();
            _cService = new Categories_Services();
            _iService = new Ingredients_Services();
            _riService = new RecipesIngredients_Services();
        }

        private void FrmRecipesInsert_Load(object sender, EventArgs e)
        {
            FillComboBoxes();
            CreateIngredientsDataTable();
        }

        private void btInsertIngredient_Click(object sender, EventArgs e)
        {
            decimal quantity;
            //int id;
            decimal.TryParse(tbQuantity.Text, out quantity);
            //int.TryParse(cbIngredients.SelectedValue.ToString(), out id);
            DataRow row = dtInsertIngredients.NewRow();
            
            //row["ID"] = cbIngredients.SelectedItem;
            row["ID"] = cbIngredients.SelectedValue;
            row["Ingrediente"] = cbIngredients.GetItemText(cbIngredients.SelectedItem);
            row["Quantidade"] = quantity;
            row["Unidade"] = cbUnity.GetItemText(cbUnity.SelectedItem);

            dtInsertIngredients.Rows.Add(row);
            FillGrid();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            //Recipe recipe = new Recipe();
            double minutes = double.Parse(tbDuration.Text);
            Category category = (Category)cbCategory.SelectedItem;

            recipe.Title = tbName.Text;
            recipe.CategoryID = category.ID;
            recipe.Difficulty = (Difficulty)cbDifficulty.SelectedItem;
            recipe.Duration = TimeSpan.FromMinutes(minutes);
            recipe.Instructions = tbInstructions.Text;

            _rService.Add(recipe);
            
            int id = recipe.ID;

            foreach (DataRow row in dtInsertIngredients.Rows)
            {
                RecipeIngredient recipeIngredient = new RecipeIngredient();
                recipeIngredient.RecipeID = id;
                recipeIngredient.IngredientID = Convert.ToInt32(row["ID"].ToString());
                recipeIngredient.Quantity = Convert.ToDecimal(row["Quantidade"].ToString());
                recipeIngredient.Unit = row["Unidade"].ToString();
                _riService.Add(recipeIngredient);
            }
            MessageBox.Show("Inserido com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void FillComboBoxes()
        {
            //DataTable dtCategory = ConvertListToDataTable.ConvertTo<Category>(_cService.GetALL());
            //cbCategory.DataSource = dtCategory;
            //foreach (Category name in _cService.GetALL())
            //{
            //    cbCategory.Items.Add(name);
            //}
            List<Category> categories = _cService.GetALL();
            var categoriesArr = categories.ToArray();
            cbCategory.Items.AddRange(categoriesArr);

            cbCategory.DisplayMember = "Name";
            //cbCategory.ValueMember = "ID";
            
            DataTable dtIngredients = ConvertListToDataTable.ConvertTo<Ingredient>(_iService.GetALL());
            cbIngredients.DataSource = dtIngredients;

            //foreach (Ingredient ingredient in _iService.GetALL())
            //{
            //    cbIngredients.Items.Add(ingredient);
            //}
            cbIngredients.DisplayMember = "Name";
            cbIngredients.ValueMember = "ID";


            foreach (var item in Enum.GetValues(typeof(Difficulty)))
            {
                cbDifficulty.Items.Add(item);
            }
        }
        private void FillGrid()
        {
            gvInsertedIngredients.DataSource = dtInsertIngredients;
            if (gvInsertedIngredients.Rows.Count > 0)
            {
                gvInsertedIngredients.Columns["ID"].Visible = false;
            }
        }


        private void CreateIngredientsDataTable()
        {
            dtInsertIngredients.Columns.Add("ID", typeof(int));
            dtInsertIngredients.Columns.Add("Ingrediente", typeof(string));
            dtInsertIngredients.Columns.Add("Quantidade", typeof(double));
            dtInsertIngredients.Columns.Add("Unidade", typeof(string));
        }      
    }
}
