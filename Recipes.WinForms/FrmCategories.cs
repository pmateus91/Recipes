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
    public partial class FrmCategories : Form
    {
        private Categories_Services _service;

        public FrmCategories()
        {
            InitializeComponent();
            _service = new Categories_Services();

        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        #region Métodos DataGridView

        public void FillGrid()
        {
            gvResultCategories.DataSource = _service.GetALL();
            VisualAspectGrid();
        }

        private void VisualAspectGrid()
        {
            if (gvResultCategories.Rows.Count > 0)
            {
                gvResultCategories.Columns["ID"].Visible = false;
                gvResultCategories.Columns["Name"].Width = 190;
                gvResultCategories.Columns["Name"].HeaderText = "Nome";
                gvResultCategories.Columns["Description"].HeaderText = "Descrição";
            }
        }
        #endregion

        private void btInsert_Click(object sender, EventArgs e)
        {
            FrmCategories_InsertUpdate FrmCategories_InsertUpdate = new FrmCategories_InsertUpdate(true);
            FrmCategories_InsertUpdate.ShowDialog();
            FillGrid();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            int idCategories;
            int.TryParse(gvResultCategories.CurrentRow.Cells["ID"].Value.ToString(), out idCategories);

            FrmCategories_InsertUpdate FrmCategories_InsertUpdate = new FrmCategories_InsertUpdate(false, idCategories);
            FrmCategories_InsertUpdate.ShowDialog();
            FillGrid();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Tem a certeza que pretende eliminar?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                int id;
                int.TryParse(gvResultCategories.CurrentRow.Cells["ID"].Value.ToString(), out id);
                _service.Remove(id);
            }
            else
            {
                FillGrid();
            }
        }
    }
}
