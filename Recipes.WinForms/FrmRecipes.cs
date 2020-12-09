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
        public FrmRecipes()
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
            FrmRecipesDetails frmRecipesDetails = new FrmRecipesDetails(Convert.ToInt32(gvResultRecepies.CurrentRow.Cells["ProductID"].Value));
            frmRecipesDetails.ShowDialog();
            frmRecipesDetails.BringToFront();

        }      

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }

        #region METHODS DATAGRIDVIEW
        private void FillGrid()
        {
            DataTable dt = ConvertListToDataTable.ConvertTo<Recipe>(_service.GetALL());
            gvResultRecepies.DataSource = dt;
            //VisualAspectGrid();
        }

        private void VisualAspectGrid()
        {
            //if (gvResultRecepies.Rows.Count > 0)
            //{
            //    gvResultUsers.Columns[$"UserID"].Visible = false;
            //    gvResultUsers.Columns[$"AccountID"].Visible = false;
            //    gvResultUsers.Columns[$"AccountID1"].Visible = false;
            //    gvResultUsers.Columns[$"Gender"].Visible = false;
            //    gvResultUsers.Columns[$"Address"].Visible = false;
            //    gvResultUsers.Columns[$"isBlocked"].HeaderText = "Bloqueado";
            //    gvResultUsers.Columns[$"isAdmin"].Visible = false;
            //    gvResultUsers.Columns[$"Password"].Visible = false;
            //    gvResultUsers.Columns["FirstName"].HeaderText = "Primeiro Nome";
            //    gvResultUsers.Columns["LastName"].HeaderText = "Último Nome";
            //    gvResultUsers.Columns["Username"].HeaderText = "UserName";
            //    gvResultUsers.Columns["Username"].DisplayIndex = 4;
            //    gvResultUsers.Columns["Email"].Width = 300;
            //}
        }
        #endregion
    }
}
