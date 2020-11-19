using Recipes.Services.Services;
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


        public FrmIngredients()
        {
            InitializeComponent();
            _service = new Ingredients_Services();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            FrmIngredients_InsertUpdate FrmIngredients_InsertUpdate = new FrmIngredients_InsertUpdate(true);
            FrmIngredients_InsertUpdate.ShowDialog();
            FillGrid();
        }


        private void btUpdate_Click(object sender, EventArgs e)
        {
            int idIngredient;
            int.TryParse(gvResultIngredients.CurrentRow.Cells["ID"].Value.ToString(), out idIngredient);

            FrmIngredients_InsertUpdate FrmIngredients_InsertUpdate = new FrmIngredients_InsertUpdate(false, idIngredient);
            FrmIngredients_InsertUpdate.ShowDialog();
            FillGrid();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Tem a certeza que pretende eliminar?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                int id;
                int.TryParse(gvResultIngredients.CurrentRow.Cells["ID"].Value.ToString(), out id);
                _service.Remove(id);
            }
            else
            {
                FillGrid();
            }

        }

        private void FrmIngredients_Load(object sender, EventArgs e)
        {
            FillGrid();
        }


        // Métodos para a GRID
        private void FillGrid()
        {
            gvResultIngredients.DataSource = _service.GetALL();
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
    }
}
