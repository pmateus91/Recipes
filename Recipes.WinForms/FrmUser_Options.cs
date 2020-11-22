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
        string _titulo;

        private Users_Services _serviceUsers;

        public FrmUser_Options(string titulo)
        {
            InitializeComponent();
            _serviceUsers = new Users_Services();
            _titulo = titulo;
        }
        FrmUser_InsertUpdate Iu;
        private void FrmUpdateBlockDelete_Load(object sender, EventArgs e)
        {
            //if (_titulo == "Utilizadores - Alterar")
            //{
            //    this.Text = "Utilizadores - Alterar";
            //    //lblTitle.Location = new Point(382, 9);
            //    lblTitle.Text = "――――――   ALTERAR   ――――――";
            //    gvResultUsers.RowHeadersWidth = 30;
            //}
            //else if (_titulo == "Utilizadores - Eliminar")
            //{
            //    this.Text = "Utilizadores - Eliminar";
            //    //lblTitle.Location = new Point(341, 9);
            //    lblTitle.Text = "――――――   ELIMINAR   ――――――";

            //    btBlock.Visible = false;
            //    btUnblock.Visible = false;
            //    btChange.Visible = false;
            //    btDelete.Visible = true;
            //    //btDelete.Location = new Point(850, 62);
            //}
            //else
            //{
            //    this.Text = "Utilizadores - Bloquear/Desbloquear";
            //    btBlock.Visible = true;
            //    btUnblock.Visible = true;
            //    btChange.Visible = false;
            //    btDelete.Visible = false;
            //    lblTitle.Text = "――――――   BLOQUEAR / DESBLOQUEAR   ――――――";
            //    //lblTitle.Location = new Point(230, 9);
            //    //btBlock.Location = new Point(850, 62);
            //    //btUnblock.Location = new Point(850, 118);
            //}
            //FillGrid();
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            //int idUser;
            //int.TryParse(gvResultUsers.CurrentRow.Cells["ID"].Value.ToString(), out idUser);
            //FrmUser_InsertUpdate frmUser_Update = new FrmUser_InsertUpdate(false, idUser);
            //frmUser_Update.ShowDialog();
            //FillGrid();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            //DialogResult res = MessageBox.Show("Tem a certeza que pretende eliminar?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (res == DialogResult.Yes)
            //{
            //    int id;
            //    int.TryParse(gvResultUsers.CurrentRow.Cells["ID"].Value.ToString(), out id);
            //    _serviceUsers.Remove(id);
            //}
            //FillGrid();
        }

        // Métodos para a GRID


        private void FillGrid()
        {
            //gvResultUsers.DataSource = _serviceUsers.GetALL();
            //VisualAspectGrid();
        }

        private void VisualAspectGrid()
        {
            //if (gvResultUsers.Rows.Count > 0)
            //{
            //    gvResultUsers.Columns[$"ID"].Visible = false;
            //    gvResultUsers.Columns[$"Gender"].Visible = false;
            //    gvResultUsers.Columns[$"Address"].Visible = false;
            //    //gvResultUsers.Columns[$"AccountID"].Visible = false;
            //    //gvResultUsers.Columns[$"isAdmin"].Visible = false;
            //    //gvResultUsers.Columns[$"isBlocked"].Visible = false;
            //    //gvResultUsers.Columns[$"Password"].Visible = false;
            //    //gvResultUsers.Columns["Username"].DisplayIndex = 1;

            //    //gvResultUsers.Columns["FirstName"].HeaderText = "Primeiro Nome";
            //    //gvResultUsers.Columns["LastName"].HeaderText = "Último Nome";
            //    //gvResultUsers.Columns["Username"].HeaderText = "UserName";

            //    //gvResultUsers.Columns["Description"].HeaderText = "Descrição";
            //}
        }
    }
}
