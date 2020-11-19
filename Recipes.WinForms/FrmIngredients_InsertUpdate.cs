using Recipes.Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Recipes.Model.Model;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipes.WinForms
{
    public partial class FrmIngredients_InsertUpdate : Form
    {
        private Ingredients_Services _service;

        Ingredient ingredient = new Ingredient();
        bool _isInsert;
        int _id;
        public FrmIngredients_InsertUpdate(bool isInsert,int id=0)
        {
            InitializeComponent();
            _service = new Ingredients_Services();
            _isInsert = isInsert;
            _id = id;
        }      

        private void btSave_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Tem a certeza que pretende inserir?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                ingredient.Name = tbNome.Text;
                ingredient.Description = tbDescricao.Text;
                ingredient.ID = _id;
                //guardar na base de dados utilizando a conn
                if (_isInsert)
                {
                    _service.Add(ingredient);
                    MessageBox.Show("Inserido com sucesso","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _service.Update(ingredient);
                    MessageBox.Show("Guardado com sucesso","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                this.Close();
            }
        }

        private void FrmInsertIngredient_Load(object sender, EventArgs e)
        {
            if (!_isInsert)            
            {
                lblTitle.Text = "―――  Alterar Ingrediente  ―――";
                lblTitle.Location = new System.Drawing.Point(4, 9);
                btSave.Image = Properties.Resources.diskette;
                foreach (var item in _service.GetById(_id))
                {
                    tbNome.Text = item.Name;
                    tbDescricao.Text = item.Description;
                }
            }
        }
    }
}
