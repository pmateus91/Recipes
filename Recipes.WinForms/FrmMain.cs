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
    public partial class FrmMain : Form
    {
        #region CONSTRUCTOR

        private bool closeSentinel = false;
        FrmRecipes frmRecipes;
        FrmIngredients frmIngredients;
        FrmIngredients_Options frmIngredients_Options;
        FrmCategories frmCategories;
        FrmCategories_Options frmCategories_Options;
        FrmUser frmUser;
        FrmUser_Options frmUser_Options;
        FrmUser_InsertUpdate frmUser_InsertUpdate;

        #endregion CONSTRUCTOR

        public FrmMain()
        {
            InitializeComponent();
        }

        #region MENU EVENTS

        #region MENU - Ficheiro
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ExitMessage())
            {
                closeSentinel = true;
                Application.Exit();
            }
        }
        #endregion MENU - Ficheiro

        #region MENU - Receitas

        private void consultarReceitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmRecipes>().Count() == 0)
                frmRecipes = new FrmRecipes();
            frmRecipes.MdiParent = this;
            frmRecipes.WindowState = FormWindowState.Maximized;
            frmRecipes.Show();
            frmRecipes.BringToFront();

        }

        #endregion MENU - Receitas

        #region MENU - Categorias

        private void consultarCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFrmCategories();
        }

        private void inserirCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategories_InsertUpdate FrmCategories_InsertUpdate = new FrmCategories_InsertUpdate(true);
            FrmCategories_InsertUpdate.ShowDialog();
            OpenFrmCategories();
        }

        private void alterarCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFrmCategories_Options("Categorias - Alterar");
        }

        private void eliminarCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFrmCategories_Options("Categorias - Eliminar");
        }

        #endregion MENU - Categorias

        #region MENU - Ingredientes

        private void consultarIngredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFrmIngredients();
        }
        private void inserirIngredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngredients_InsertUpdate FrmIngredients_InsertUpdate = new FrmIngredients_InsertUpdate(true);
            FrmIngredients_InsertUpdate.ShowDialog();
            OpenFrmIngredients();
        }
        private void alterarIngredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFrmIngredients_Options("Ingredientes - Alterar");
        }

        private void eliminarIngredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFrmIngredients_Options("Ingredientes - Eliminar");
        }

        #endregion MENU - Ingredientes

        #region MENU - Utilizadores

        private void consultarUtilizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFrmUser();
        }
        private void inserirUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmUser_InsertUpdate>().Count() == 0)
                frmUser_InsertUpdate = new FrmUser_InsertUpdate(true);
            //FrmUser_InsertUpdate.MdiParent = this;
            frmUser_InsertUpdate.BringToFront();
            frmUser_InsertUpdate.ShowDialog();
            if (Application.OpenForms.OfType<FrmUser>().Count() == 0)
                frmUser = new FrmUser("Utilizadores - Alterar");
            else
            {
                frmUser.Close();
                frmUser = new FrmUser("Utilizadores - Alterar");
            }
            frmUser.MdiParent = this;
            frmUser.WindowState = FormWindowState.Maximized;
            frmUser.Show();
            frmUser.BringToFront();

        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFrmUser_Options("Utilizadores - Alterar");


            //if (Application.OpenForms.OfType<FrmUser>().Count() == 0)
            //    frmUser = new FrmUser("Utilizadores - Alterar");
            //else
            //{
            //    frmUser.Close();
            //    frmUser = new FrmUser("Utilizadores - Alterar");
            //}
            //frmUser.MdiParent = this;
            //frmUser.WindowState = FormWindowState.Maximized;
            //frmUser.Show();
            //frmUser.BringToFront();
        }

        private void bloquearDesbloquearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (Application.OpenForms.OfType<FrmUser>().Count() == 0)
            //    frmUser = new FrmUser("Utilizadores - Bloquear/Desbloquear");
            //else
            //{
            //    frmUser.Close();
            //    frmUser = new FrmUser("Utilizador - Bloquear/Desbloquear");
            //}
            //frmUser.MdiParent = this;

            //frmUser.WindowState = FormWindowState.Maximized;
            //frmUser.Show();
            //frmUser.BringToFront();
            OpenFrmUser_Options("Utilizadores - Bloquear / Desbloquear");

        }

        private void eliminarUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (Application.OpenForms.OfType<FrmUser>().Count() == 0)
            //    frmUser = new FrmUser("Utilizadores - Eliminar");
            //else
            //{
            //    frmUser.Close();
            //    frmUser = new FrmUser("Utilizadores - Eliminar");
            //}
            //frmUser.MdiParent = this;
            //frmUser.WindowState = FormWindowState.Maximized;
            //frmUser.Show();
            //frmUser.BringToFront();

            OpenFrmUser_Options("Utilizadores - Eliminar");

        }

        #endregion MENU - Utilizadores

        #region MENU - Janela

        private void fecharTodasAsJanelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int FrmIngredients = Application.OpenForms.Count - 1; FrmIngredients >= 0; FrmIngredients--)
            {
                if (Application.OpenForms[FrmIngredients].Name != "FrmMain")
                {
                    Application.OpenForms[FrmIngredients].Close();
                }
            }
        }




        #endregion MENU - Janela

        #region MENU - Ajuda



        #endregion MENU - Ajuda

        #endregion MENU EVENTS


        #region METHODS

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (!closeSentinel)
            {
                if (ExitMessage())
                {
                    Dispose(true);
                    Application.Exit();
                }
                e.Cancel = true;
            }
        }
        private bool ExitMessage()
        {
            DialogResult res = MessageBox.Show("Tem a certeza que pretende sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
                return true;
            return false;
        }

        private void OpenFrmReceitas()
        {

        }
        private void OpenFrmReceitas_Options(string title)
        {

        }

        private void OpenFrmCategories()
        {
            if (Application.OpenForms.OfType<FrmCategories>().Count() > 0)
            {
                frmCategories.Close();
            }
            if (Application.OpenForms.OfType<FrmCategories>().Count() == 0)
            {
                frmCategories = new FrmCategories("Categorias - Consultar");
            }
            frmCategories.MdiParent = this;
            frmCategories.WindowState = FormWindowState.Maximized;
            frmCategories.Show();
            frmCategories.BringToFront();
        }
        private void OpenFrmCategories_Options(string title)
        {
            if (Application.OpenForms.OfType<FrmCategories_Options>().Count() > 0)
            {
                frmCategories_Options.Close();
            }
            if (Application.OpenForms.OfType<FrmCategories_Options>().Count() == 0)
            {
                frmCategories_Options = new FrmCategories_Options(title);
            }

            frmCategories_Options.MdiParent = this;
            frmCategories_Options.WindowState = FormWindowState.Maximized;
            frmCategories_Options.Show();
            frmCategories_Options.BringToFront();
        }

        private void OpenFrmIngredients()
        {
            if (Application.OpenForms.OfType<FrmIngredients>().Count() > 0)
            {
                frmIngredients.Close();
            }
            if (Application.OpenForms.OfType<FrmIngredients>().Count() == 0)
            {
                frmIngredients = new FrmIngredients("Ingredientes - Consultar");
            }
            frmIngredients.MdiParent = this;
            frmIngredients.WindowState = FormWindowState.Maximized;
            frmIngredients.Show();
            frmIngredients.BringToFront();
        }
        private void OpenFrmIngredients_Options(string title)
        {

            if (Application.OpenForms.OfType<FrmIngredients_Options>().Count() > 0)
            {
                frmIngredients_Options.Close();
            }
            if (Application.OpenForms.OfType<FrmIngredients_Options>().Count() == 0)
                frmIngredients_Options = new FrmIngredients_Options(title);

            frmIngredients_Options.MdiParent = this;
            frmIngredients_Options.WindowState = FormWindowState.Maximized;
            frmIngredients_Options.Show();
            frmIngredients_Options.BringToFront();
        }

        private void OpenFrmUser()
        {
            if (Application.OpenForms.OfType<FrmUser>().Count() > 0)
            {
                frmUser.Close();
            }
            if (Application.OpenForms.OfType<FrmUser>().Count() == 0)
            {
                frmUser = new FrmUser("Utilizadores - Consultar");
            }
            frmUser.MdiParent = this;
            frmUser.WindowState = FormWindowState.Maximized;
            frmUser.Show();
            frmUser.BringToFront();
        }
        private void OpenFrmUser_Options(string title)
        {
            if (Application.OpenForms.OfType<FrmUser_Options>().Count() > 0)
            {
                frmUser_Options.Close();
            }
            if (Application.OpenForms.OfType<FrmUser_Options>().Count() == 0)
                frmUser_Options = new FrmUser_Options(title);

            frmUser_Options.MdiParent = this;
            frmUser_Options.WindowState = FormWindowState.Maximized;
            frmUser_Options.Show();
            frmUser_Options.BringToFront();
        }

        #endregion METHODS       

        
    }

}
