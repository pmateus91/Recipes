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
    public partial class FrmCategories : Form
    {
        private Categories_Services _service;
        string _title, rowFilter;

        public FrmCategories(string title)
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

        #region METHODS DATAGRIDVIEW

        public void FillGrid()
        {
            DataTable dt = ConvertListToDataTable.ConvertTo<Category>(_service.GetALL());
            gvResultCategories.DataSource = dt;
            VisualAspectGrid();
        }

        private void gvResultCategories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

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
