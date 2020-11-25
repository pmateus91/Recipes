using Recipes.Services.Services;
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

    public partial class FrmRecipes_Options : Form
    {
        private Recipes_Services _service;
        public FrmRecipes_Options()
        {
            InitializeComponent();
            _service = new Recipes_Services();
        }

        private void FrmRecipes_Load(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void fillGrid()
        {
            gvResultRecepies.DataSource = _service.GetAllProducts();
            VisualAspectGrid();
        }

        private void gvResultRecepies_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //aqui abrimos o form detalhe da receita
            FrmRecipesDetails frmRecipesDetails = new FrmRecipesDetails(Convert.ToInt32(gvResultRecepies.CurrentRow.Cells["ProductID"].Value));
            frmRecipesDetails.ShowDialog();
            frmRecipesDetails.BringToFront();

        }
        private void VisualAspectGrid()
        {
            gvResultRecepies.Columns["ProductID"].Visible = false;
        }
    }
}
