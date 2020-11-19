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
        private bool closeSentinel = false;
        public FrmMain()
        {
            InitializeComponent();
        }
        FrmRecipes R;
        FrmIngredients I;
        FrmCategories Ca;
        FrmComments Co;
        FrmTime T;
        FrmUser_Insert Iu;
        FrmUser_UpdateBlockDelete Ubd;

        #region Consultar

        private void receitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmRecipes>().Count() == 0)
                R = new FrmRecipes();
            R.MdiParent = this;
            R.WindowState = FormWindowState.Maximized;
            R.Show();
            R.BringToFront();
        }

        private void ingredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmIngredients>().Count() == 0)
                I = new FrmIngredients();
            I.MdiParent = this;
            I.WindowState = FormWindowState.Maximized;
            I.Show();
            I.BringToFront();
        }      

        private void tempoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmTime>().Count() == 0)
                T = new FrmTime();
            T.MdiParent = this;
            T.WindowState = FormWindowState.Maximized;
            T.Show();
            T.BringToFront();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCategories>().Count() == 0)
                Ca = new FrmCategories();
            Ca.MdiParent = this;
            Ca.WindowState = FormWindowState.Maximized;
            Ca.Show();
            Ca.BringToFront();
        }

        private void comentáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmComments>().Count() == 0)
                Co = new FrmComments();
            Co.MdiParent = this;
            Co.WindowState = FormWindowState.Maximized;
            Co.Show();
            Co.BringToFront();
        }
        #endregion


        #region Utilizadores

        private void inserirUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmUser_Insert>().Count() == 0)
                Iu = new FrmUser_Insert();
            //Iu.MdiParent = this;
            Iu.ShowDialog();
            Iu.BringToFront();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmUser_UpdateBlockDelete>().Count() == 0)
                Ubd = new FrmUser_UpdateBlockDelete("Alterar");
            else
            {
                Ubd.Close();
                Ubd = new FrmUser_UpdateBlockDelete("Alterar");
            }
            Ubd.MdiParent = this;
            Ubd.WindowState = FormWindowState.Maximized;
            Ubd.Show();
            Ubd.BringToFront();
        }

        private void bloquearDesbloquearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmUser_UpdateBlockDelete>().Count() == 0)
                Ubd = new FrmUser_UpdateBlockDelete("Bloquear/Desbloquear");
            else
            {
                Ubd.Close();
                Ubd = new FrmUser_UpdateBlockDelete("Bloquear/Desbloquear");
            }
            Ubd.MdiParent = this;

            Ubd.WindowState = FormWindowState.Maximized;
            Ubd.Show();
            Ubd.BringToFront();
        }

        private void eliminarUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmUser_UpdateBlockDelete>().Count() == 0)
                Ubd = new FrmUser_UpdateBlockDelete("Eliminar");
            else
            {
                Ubd.Close();
                Ubd = new FrmUser_UpdateBlockDelete("Eliminar");
            }
            Ubd.MdiParent = this;
            Ubd.WindowState = FormWindowState.Maximized;
            Ubd.Show();
            Ubd.BringToFront();
        }

        #endregion


        #region Menu Options
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ExitMessage())
            {
                closeSentinel = true;
                Application.Exit();
            }
        }
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
        #endregion
    }
}
