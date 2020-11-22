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
    public partial class FrmIngredients_Options : Form
    {
        private Ingredients_Services _service;
        string _title, rowFilter;


        public FrmIngredients_Options(string title)
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

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (_title == "Ingredientes - Alterar")
            {
                int idCategories;
                int.TryParse(gvResultIngredients.CurrentRow.Cells["ID"].Value.ToString(), out idCategories);

                FrmIngredients_InsertUpdate frmIngredients_InsertUpdate = new FrmIngredients_InsertUpdate(false, idCategories);
                frmIngredients_InsertUpdate.ShowDialog();
                FillGrid();
            }
            else
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
            

            //int idIngredient;
            //int.TryParse(gvResultIngredients.CurrentRow.Cells["ID"].Value.ToString(), out idIngredient);

            //FrmIngredients_InsertUpdate FrmIngredients_InsertUpdate = new FrmIngredients_InsertUpdate(false, idIngredient);
            //FrmIngredients_InsertUpdate.ShowDialog();
            //FillGrid();
        }

        //private void btInsert_Click(object sender, EventArgs e)
        //{
        //    FrmIngredients_InsertUpdate FrmIngredients_InsertUpdate = new FrmIngredients_InsertUpdate(true);
        //    FrmIngredients_InsertUpdate.ShowDialog();
        //    FillGrid();
        //}

        //private void btDelete_Click(object sender, EventArgs e)
        //{
        //    DialogResult res = MessageBox.Show("Tem a certeza que pretende eliminar?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (res == DialogResult.Yes)
        //    {
        //        int id;
        //        int.TryParse(gvResultIngredients.CurrentRow.Cells["ID"].Value.ToString(), out id);
        //        _service.Remove(id);
        //    }
        //    else
        //    {
        //        FillGrid();
        //    }

        //}


        #region METHODS DATAGRIDVIEW
        private void FillGrid()
        {
            if (_title == "Ingredientes - Alterar")
            {
                lblTitle.Text = "――――――   ALTERAR   ――――――";
                DataTable dt = ConvertListToDataTable.ConvertTo<Ingredient>(_service.GetALL());
                gvResultIngredients.DataSource = dt;
                VisualAspectGrid();
            }
            else
            {
                lblTitle.Text = "――――――   ELIMINAR   ――――――";
                btUpdate.Text = "Eliminar";
                btUpdate.Image = Properties.Resources.delete;
                DataTable dt = ConvertListToDataTable.ConvertTo<Ingredient>(_service.GetALL());
                gvResultIngredients.DataSource = dt;
                VisualAspectGrid();
            }
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
