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
    public partial class FrmUpdateBlockDelete : Form
    {
        string _titulo;
        public FrmUpdateBlockDelete(string titulo)
        {
            InitializeComponent();
            _titulo = titulo;
        }
        FrmInsertUser Iu;
        private void FrmUpdateBlockDelete_Load(object sender, EventArgs e)
        {
            if (_titulo == "Alterar")
            {
                this.Text = "Alterar";
                lblTitulo.Location = new Point(382, 9);
                lblTitulo.Text = "Alterar";
            }
            else if (_titulo == "Eliminar")
            {
                this.Text = "Eliminar";
                lblTitulo.Location = new Point(341, 9);
                lblTitulo.Text = "Eliminar";

                btBlock.Visible = false;
                btUnblock.Visible = false;
                btChange.Visible = false;
                btDelete.Visible = true;
                btDelete.Location = new Point(850, 46);
            }
            else
            {
                this.Text = "Bloquear/Desbloquear";
                btBlock.Visible = true;
                btUnblock.Visible = true;
                btChange.Visible = false;
                btDelete.Visible = false;
                lblTitulo.Text = "Bloquear/Desbloquear";
                lblTitulo.Location = new Point(230, 9);
                btBlock.Location = new Point(850, 46);
                btUnblock.Location = new Point(850, 102);
            }
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            if (gvResult.Rows.Count > 0)
            {                
                if (Application.OpenForms.OfType<FrmInsertUser>().Count() == 0)
                    Iu = new FrmInsertUser();
                //Iu.MdiParent = this;
                Iu.ShowDialog();
                Iu.BringToFront();
            }
        }
    }
}
