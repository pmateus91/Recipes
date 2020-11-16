using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recepies.WinForms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        FrmRecipes R;
        FrmIngredients I;
        FrmCategories Ca;
        FrmComents Co;
        FrmTime T;
        FrmInsertUser Iu;
        FrmUpdateBlockDelete Ubd;

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

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Tem a certeza que pretende sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else 
            {
                e.Cancel = true;
            }
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
            if (Application.OpenForms.OfType<FrmComents>().Count() == 0)
                Co = new FrmComents();
            Co.MdiParent = this;
            Co.WindowState = FormWindowState.Maximized;
            Co.Show();
            Co.BringToFront();
        }

        private void inserirUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmInsertUser>().Count() == 0)
                Iu = new FrmInsertUser();
            //Iu.MdiParent = this;
            Iu.ShowDialog();
            Iu.BringToFront();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmUpdateBlockDelete>().Count() == 0)
                Ubd = new FrmUpdateBlockDelete("Alterar");
            else
            {
                Ubd.Close();
                Ubd = new FrmUpdateBlockDelete("Alterar");
            }
            Ubd.MdiParent = this;
            Ubd.WindowState = FormWindowState.Maximized;
            Ubd.Show();
            Ubd.BringToFront();
        }

        private void bloquearDesbloquearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmUpdateBlockDelete>().Count() == 0)
                Ubd = new FrmUpdateBlockDelete("Bloquear/Desbloquear");
            else
            {
                Ubd.Close();
                Ubd = new FrmUpdateBlockDelete("Bloquear/Desbloquear");
            }
            Ubd.MdiParent = this;

            Ubd.WindowState = FormWindowState.Maximized;
            Ubd.Show();
            Ubd.BringToFront();
        }

        private void eliminarUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmUpdateBlockDelete>().Count() == 0)
                Ubd = new FrmUpdateBlockDelete("Eliminar");
            else
            {
                Ubd.Close();
                Ubd = new FrmUpdateBlockDelete("Eliminar");
            }
            Ubd.MdiParent = this;
            Ubd.WindowState = FormWindowState.Maximized;
            Ubd.Show();
            Ubd.BringToFront();
        }
    }
}
