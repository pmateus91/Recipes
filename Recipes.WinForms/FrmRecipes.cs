using PMLibrary;
using Recipes.Services.Services;
using Recipes.Model.Model;
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

    public partial class FrmRecipes : Form
    {
        private Recipes_Services _service;
        string _title, rowFilter;

        public FrmRecipes(string title)
        {
            InitializeComponent();
            _service = new Recipes_Services();

        }

        private void FrmRecipes_Load(object sender, EventArgs e)
        {
            FillGrid();
        }       

        private void gvResultRecepies_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //aqui abrimos o form detalhe da receita
            FrmRecipesDetails frmRecipesDetails = new FrmRecipesDetails(Convert.ToInt32(gvResultRecepies.CurrentRow.Cells["ID"].Value));
            frmRecipesDetails.ShowDialog();
            frmRecipesDetails.BringToFront();

        }      

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (gvResultRecepies.Rows.Count >= 0)
            {
                rowFilter = "";
                rowFilter += string.Format("Title LIKE '%{0}%'", tbSearch.Text);

                (gvResultRecepies.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
        }

        #region METHODS DATAGRIDVIEW
        private void FillGrid()
        {
            DataTable dt = ConvertListToDataTable.ConvertTo<Recipe>(_service.GetALL());
            gvResultRecepies.DataSource = dt;
            VisualAspectGrid();
        }

        private void VisualAspectGrid()
        {
            if (gvResultRecepies.Rows.Count > 0)
            {
                gvResultRecepies.Columns[$"ID"].Visible = false;
                gvResultRecepies.Columns[$"CategoryID"].Visible = false;
                gvResultRecepies.Columns[$"User"].Visible = false;
                gvResultRecepies.Columns[$"CategoryName"].HeaderText = "Categoria";
                gvResultRecepies.Columns[$"CategoryName"].DisplayIndex = 2;
                gvResultRecepies.Columns[$"Duration"].HeaderText = "Duração";
                gvResultRecepies.Columns[$"Difficulty"].HeaderText = "Dificuldade";
                gvResultRecepies.Columns[$"Status"].HeaderText = "Validado";
                gvResultRecepies.Columns[$"Title"].HeaderText = "Titulo";                
            }
        }
        #endregion
    }
}
