using Recipes.Services.Services;
using Recipes.Model.Model;
using MLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipes.WinForms
{
    public partial class FrmIngredients : Form
    {
        private Ingredients_Services _service;
        string _title, rowFilter;

        public FrmIngredients(string title)
        {
            InitializeComponent();
            _service = new Ingredients_Services();
            _title = title;
        }

        private void FrmIngredients_Load(object sender, EventArgs e)
        {
            FillGrid();
        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (gvResultIngredients.Rows.Count >= 0)
            {
                rowFilter = "";
                rowFilter += string.Format("Name LIKE '%{0}%'", tbSearch.Text);

                (gvResultIngredients.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
        }

        #region METHODS DATAGRIDVIEW
        private void FillGrid()
        {
            DataTable dt = ConvertListToDataTable.ConvertTo<Ingredient>(_service.GetALL());
            gvResultIngredients.DataSource = dt;
            VisualAspectGrid();
        }        

        private void VisualAspectGrid()
        {
            if (gvResultIngredients.Rows.Count > 0)
            {
                gvResultIngredients.Columns["ID"].Visible = false;
                gvResultIngredients.Columns["Name"].Width = 190;
                gvResultIngredients.Columns["Name"].HeaderText = "Nome";
                gvResultIngredients.Columns["Description"].HeaderText = "Descrição";
            }
        }
        #endregion
    }
}
