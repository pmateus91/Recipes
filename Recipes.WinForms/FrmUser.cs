using Recipes.Services.Services;
using Recipes.Model.Model;
using PMLibrary;
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
    public partial class FrmUser : Form
    {
        private Users_Services _service;
        string _title, rowFilter;


        public FrmUser(string titulo)
        {
            InitializeComponent();
            _service = new Users_Services();
            _title = titulo;
        }
        private void FrmUsers_Load(object sender, EventArgs e)
        {
            FillGrid();
        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (gvResultUsers.Rows.Count >= 0)
            {
                rowFilter = "";
                rowFilter += string.Format("Username LIKE '%{0}%'" + " OR FirstName LIKE '%{0}%'" + " OR LastName LIKE '%{0}%'", tbSearch.Text);
                (gvResultUsers.DataSource as DataTable).DefaultView.RowFilter = rowFilter;            
            }
        }

        #region METHODS DATAGRIDVIEW
        private void FillGrid()
        {
            DataTable dt = _service.getUserDataTable;
            gvResultUsers.DataSource = dt;
            VisualAspectGrid();
        }

        private void VisualAspectGrid()
        {
            if (gvResultUsers.Rows.Count > 0)
            {
                gvResultUsers.Columns[$"UserID"].Visible = false;
                gvResultUsers.Columns[$"AccountID"].Visible = false;
                gvResultUsers.Columns[$"AccountID1"].Visible = false;
                gvResultUsers.Columns[$"Gender"].Visible = false;
                gvResultUsers.Columns[$"Address"].Visible = false;
                gvResultUsers.Columns[$"isBlocked"].HeaderText = "Bloqueado";
                gvResultUsers.Columns[$"isAdmin"].Visible = false;
                gvResultUsers.Columns[$"Password"].Visible = false;
                gvResultUsers.Columns["FirstName"].HeaderText = "Primeiro Nome";
                gvResultUsers.Columns["LastName"].HeaderText = "Último Nome";
                gvResultUsers.Columns["Username"].HeaderText = "UserName";
                gvResultUsers.Columns["Username"].DisplayIndex = 4;
                gvResultUsers.Columns["Email"].Width = 300;
            }
        }
        #endregion


    }


}
