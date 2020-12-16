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
    public partial class FrmUser_Options : Form
    {
        private Users_Services _service;
        User user = new User();
        string _title, rowFilter;

        public FrmUser_Options(string titulo)
        {
            InitializeComponent();
            _service = new Users_Services();
            _title = titulo;
        }
        private void FrmUser_Options_Load(object sender, EventArgs e)
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

        private void btChange_Click(object sender, EventArgs e)
        {
            if (_title == "Utilizadores - Alterar")
            {
                int id;
                int.TryParse(gvResultUsers.CurrentRow.Cells["UserID"].Value.ToString(), out id);
                FrmUser_InsertUpdate frmUser_Update = new FrmUser_InsertUpdate(false, id);
                frmUser_Update.ShowDialog();
                FillGrid();
            }
            else if (_title == "Utilizadores - Bloquear / Desbloquear")
            {
                DialogResult res = MessageBox.Show("Tem a certeza que pretende bloquear?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    int id;
                    int.TryParse(gvResultUsers.CurrentRow.Cells["UserID"].Value.ToString(), out id);
                    user.ID = id;
                    user.IsBlocked = true;
                    _service.UpdateBlockedStatus(user);
                    MessageBox.Show("Bloqueado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    FillGrid();
                }
            }
            else
            {
                DialogResult res = MessageBox.Show("Tem a certeza que pretende eliminar?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    int id;
                    int.TryParse(gvResultUsers.CurrentRow.Cells["UserID"].Value.ToString(), out id);
                    _service.Remove(id);
                }
                else
                {
                    FillGrid();
                }
            }
            FillGrid();

        }

        private void btUnblock_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Tem a certeza que pretende desbloquear?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                int id;
                int.TryParse(gvResultUsers.CurrentRow.Cells["UserID"].Value.ToString(), out id);
                user.ID = id;
                user.IsBlocked = false;
                _service.UpdateBlockedStatus(user);
                MessageBox.Show("Desbloqueado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                FillGrid();
            }
            FillGrid();

        }

        #region METHODS DATAGRIDVIEW

        private void FillGrid()
        {
            if (_title == "Utilizadores - Alterar")
            {
                lblTitle.Text = "――――――   ALTERAR   ――――――";
                DataTable dt = _service.getUserDataTable;
                gvResultUsers.DataSource = dt;
                VisualAspectGrid_Options();
            }
            else if (_title == "Utilizadores - Bloquear / Desbloquear")
            {
                lblTitle.Text = "――――――   BLOQUEAR / DESBLOQUEAR   ――――――";
                btChange.Text = "Bloquear";
                btChange.Image = Properties.Resources.status_busy;
                btUnblock.Visible = true;
                DataTable dt = _service.getUserDataTable;
                gvResultUsers.DataSource = dt;
                VisualAspectGrid_Options();
            }
            else
            {
                lblTitle.Text = "――――――   ELIMINAR   ――――――";
                btChange.Text = "Eliminar";
                btChange.Image = Properties.Resources.delete;
                DataTable dt = _service.getUserDataTable;
                gvResultUsers.DataSource = dt;
                VisualAspectGrid_Options();
            }
        }

        //private void VisualAspectGrid()
        //{
        //    if (gvResultUsers.Rows.Count > 0)
        //    {
        //        gvResultUsers.Columns[$"UserID"].Visible = false;
        //        gvResultUsers.Columns[$"AccountID"].Visible = false;
        //        gvResultUsers.Columns[$"AccountID1"].Visible = false;
        //        gvResultUsers.Columns[$"Gender"].Visible = false;
        //        gvResultUsers.Columns[$"Address"].Visible = false;
        //        gvResultUsers.Columns[$"isBlocked"].HeaderText = "Bloqueado";
        //        gvResultUsers.Columns[$"isAdmin"].Visible = false;
        //        gvResultUsers.Columns[$"Password"].Visible = false;
        //        gvResultUsers.Columns["FirstName"].HeaderText = "Primeiro Nome";
        //        gvResultUsers.Columns["LastName"].HeaderText = "Último Nome";
        //        gvResultUsers.Columns["Username"].HeaderText = "UserName";
        //        gvResultUsers.Columns["Username"].DisplayIndex = 4;
        //        gvResultUsers.Columns["Email"].Width = 300;
        //    }
        //}

        

        private void VisualAspectGrid_Options()
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
                gvResultUsers.Columns["FirstName"].Width = 145;
                gvResultUsers.Columns["LastName"].HeaderText = "Último Nome";
                gvResultUsers.Columns["LastName"].Width = 145;
                gvResultUsers.Columns["Username"].HeaderText = "UserName";
                gvResultUsers.Columns["Username"].DisplayIndex = 4;
                gvResultUsers.Columns["Username"].Width = 140;
                gvResultUsers.Columns["Email"].Width = 300;
            }
        }
        #endregion

    }
}
