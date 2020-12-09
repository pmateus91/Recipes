using Recipes.Services.Services;
using Recipes.Model.Model.Utils;
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
    public partial class FrmUser_InsertUpdate : Form
    {
        FrmUser u;

        private Users_Services _serviceUsers;
        User user = new User();
        Account account = new Account();

        bool _isInsert;
        int _id;
        string gender;

        public FrmUser_InsertUpdate(bool isInsert, int id = 0)
        {
            InitializeComponent();
            _serviceUsers = new Users_Services();
            _isInsert = isInsert;
            _id = id;
        }

        private void btSave_Click(object sender, EventArgs e)
        {           
            if (string.IsNullOrWhiteSpace(tbFirstName.Text) || string.IsNullOrWhiteSpace(tbLastName.Text) || string.IsNullOrWhiteSpace(tbEmail.Text) || string.IsNullOrWhiteSpace(tbUserName.Text) || string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Existem dados por preencher", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GiveGender();
                user.FirstName = tbFirstName.Text;
                user.LastName = tbLastName.Text;
                user.Address = tbAdress.Text;
                user.Email = tbEmail.Text;
                user.IsAdmin = cbIsAdmin.Checked;
                user.IsBlocked = false;
                account.Username = tbUserName.Text;
                account.Password = tbPassword.Text;

                if (_isInsert)
                {
                    DialogResult res = MessageBox.Show("Tem a certeza que pretende inserir?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        if (tbPassword.Text == tbConfirmPassword.Text)
                        {
                            _serviceUsers.Add(user, account);
                            MessageBox.Show("Inserido com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("As Passwords não coincidem", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    DialogResult resAlt = MessageBox.Show("Tem a certeza que pretende Alterar?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resAlt == DialogResult.Yes)
                    {
                        if (tbPassword.Text == tbConfirmPassword.Text)
                        {
                            _serviceUsers.Update(user, account);
                            MessageBox.Show("Guardado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("As Passwords não coincidem", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void FrmUser_Insert_Load(object sender, EventArgs e)
        {
            if (!_isInsert)
            {
                GetGender();
                lblTitle.Text = "―――  Alterar Utilizador  ―――";
                lblTitle.Location = new System.Drawing.Point(4, 9);
                btSave.Image = Properties.Resources.diskette;

                user.ID = _serviceUsers.GetById(_id).ID;
                tbFirstName.Text = _serviceUsers.GetById(_id).FirstName;
                tbLastName.Text = _serviceUsers.GetById(_id).LastName;
                tbAdress.Text = _serviceUsers.GetById(_id).Address;
                tbEmail.Text = _serviceUsers.GetById(_id).Email;
                cbIsAdmin.Checked = _serviceUsers.GetById(_id).IsAdmin;
                cbGender.Text = gender;
                account.AccountID = _serviceUsers.GetById(_id).Account.AccountID;
                tbUserName.Text = _serviceUsers.GetById(_id).Account.Username;
                tbPassword.Text = _serviceUsers.GetById(_id).Account.Password;
                tbConfirmPassword.Text = _serviceUsers.GetById(_id).Account.Password;
            }
        }

        private void GiveGender()
        {
            if (cbGender.Text == "Masculino")
            {
                user.Gender = Gender.Male;
            }
            else if (cbGender.Text == "Feminino")
            {
                user.Gender = Gender.Female;
            }
            else
                user.Gender = Gender.Notknown;
        }

        private void GetGender()
        {
            if (_serviceUsers.GetById(_id).Gender == (Gender.Male))
            {
                gender = "Masculino";
            }
            else if (_serviceUsers.GetById(_id).Gender == (Gender.Female))
            {
                gender = "Feminino";
            }
            else
                gender = "";
        }

    }
}
