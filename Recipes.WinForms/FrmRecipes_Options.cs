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

    public partial class FrmRecipes_Options : Form
    {
        private Recipes_Services _service;
        Recipe recipe = new Recipe();
        string _title, rowFilter;

        public FrmRecipes_Options(string title)
        {
            InitializeComponent();
            _service = new Recipes_Services();
            _title = title;

        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (gvResultRecepies.Rows.Count >= 0)
            {
                rowFilter = "";
                rowFilter += string.Format("Title LIKE '%{0}%'", tbSearch.Text);

                (gvResultRecepies.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
        }

        private void FrmRecipes_Load(object sender, EventArgs e)
        {
            FillGrid();
        }
        private void btUpdateFalse_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Tem a certeza que pretende a receita por validar?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                int id;
                int.TryParse(gvResultRecepies.CurrentRow.Cells["ID"].Value.ToString(), out id);
                recipe.ID = id;
                recipe.Status = false;
                _service.UpdateStatus(recipe);
                MessageBox.Show("Receita por validar com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                FillGrid();
            }
            FillGrid();
        }

        private void btUpdate_Click_1(object sender, EventArgs e)
        {
            if (_title == "Receitas - Validar")
            {
                DialogResult res = MessageBox.Show("Tem a certeza que pretende Validar?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    int id;
                    int.TryParse(gvResultRecepies.CurrentRow.Cells["ID"].Value.ToString(), out id);
                    recipe.ID = id;
                    recipe.Status = true;
                    _service.UpdateStatus(recipe);
                    MessageBox.Show("Validado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    FillGrid();
                }
                FillGrid();

            }
            else if (_title == "Receitas - Alterar")
            {
                int idRecipes;
                int.TryParse(gvResultRecepies.CurrentRow.Cells["ID"].Value.ToString(), out idRecipes);

                FrmRecipesInsert FrmRecipesInsert = new FrmRecipesInsert(false, idRecipes);
                FrmRecipesInsert.ShowDialog();
                FillGrid();
            }
            else
            {
                DialogResult res = MessageBox.Show("Tem a certeza que pretende eliminar?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    int id;
                    int.TryParse(gvResultRecepies.CurrentRow.Cells["ID"].Value.ToString(), out id);
                    _service.Remove(id);
                }
                else
                {
                    FillGrid();
                }
            }
        }

        private void FillGrid()
        {
            if (_title == "Receitas - Validar")
            {
                lblTitle.Text = "――――――   VALIDAR   ――――――";
                DataTable dt = ConvertListToDataTable.ConvertTo<Recipe>(_service.GetALL());
                gvResultRecepies.DataSource = dt;
                btUpdateFalse.Visible = true;
                VisualAspectGrid();
            }
            else if (_title == "Receitas - Alterar")
            {
                lblTitle.Text = "――――――   ALTERAR   ――――――";
                btUpdate.Text = "Alterar";
                btUpdate.Image = Properties.Resources.diskette;
                DataTable dt = ConvertListToDataTable.ConvertTo<Recipe>(_service.GetALL());
                gvResultRecepies.DataSource = dt;
                VisualAspectGrid();
            }
            else
            {
                lblTitle.Text = "――――――   ELIMINAR   ――――――";
                btUpdate.Text = "Eliminar";
                btUpdate.Image = Properties.Resources.delete;
                DataTable dt = ConvertListToDataTable.ConvertTo<Recipe>(_service.GetALL());
                gvResultRecepies.DataSource = dt;
                VisualAspectGrid();
            }
            VisualAspectGrid();
        }

       

        private void VisualAspectGrid()
        {
            if (gvResultRecepies.Rows.Count > 0)
            {
                gvResultRecepies.Columns[$"ID"].Visible = false;
                gvResultRecepies.Columns[$"CategoryID"].Visible = false;
                gvResultRecepies.Columns[$"User"].Visible = false;
                gvResultRecepies.Columns[$"CategoryName"].HeaderText = "Categoria";
                gvResultRecepies.Columns[$"CategoryName"].DisplayIndex = 2;
                gvResultRecepies.Columns[$"Duration"].HeaderText = "Duração";
                gvResultRecepies.Columns[$"Difficulty"].HeaderText = "Dificuldade";
                gvResultRecepies.Columns[$"Status"].HeaderText = "Validado";
                gvResultRecepies.Columns[$"Title"].HeaderText = "Titulo";
            }
        }
    }
}
