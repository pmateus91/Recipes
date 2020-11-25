using PMLibrary;
using Recipes.Model.Model;
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
    public partial class FrmCategories_Options : Form
    {
        private Categories_Services _service;
        string _title, rowFilter;


        public FrmCategories_Options(string title)
        {
            InitializeComponent();
            _service = new Categories_Services();
            _title = title;
        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            FillGrid();
        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (gvResultCategories.Rows.Count >= 0)
            {
                rowFilter = "";
                rowFilter += string.Format("Name LIKE '%{0}%'", tbSearch.Text);

                (gvResultCategories.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }

        }
        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (_title == "Categorias - Alterar")
            {
                int idCategories;
                int.TryParse(gvResultCategories.CurrentRow.Cells["ID"].Value.ToString(), out idCategories);

                FrmCategories_InsertUpdate FrmCategories_InsertUpdate = new FrmCategories_InsertUpdate(false, idCategories);
                FrmCategories_InsertUpdate.ShowDialog();
                FillGrid();
            }
            else
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

        #region METHODS DATAGRIDVIEW

        public void FillGrid()
        {
            if (_title == "Categorias - Alterar")
            {
                lblTitle.Text = "――――――   ALTERAR   ――――――";
                DataTable dt = ConvertListToDataTable.ConvertTo<Category>(_service.GetALL());
                gvResultCategories.DataSource = dt;
                VisualAspectGrid();
            }
            else
            {
                lblTitle.Text = "――――――   ELIMINAR   ――――――";
                btUpdate.Text = "Eliminar";
                btUpdate.Image = Properties.Resources.delete;
                DataTable dt = ConvertListToDataTable.ConvertTo<Category>(_service.GetALL());
                gvResultCategories.DataSource = dt;
                VisualAspectGrid();
            }
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
       
    }
}

