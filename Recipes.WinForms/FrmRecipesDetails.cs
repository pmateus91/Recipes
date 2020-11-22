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
    public partial class FrmRecipesDetails : Form
    {
        int _id;
        private Recipes_Services _service;

        public FrmRecipesDetails()
        {
            InitializeComponent();
            _service = new Recipes_Services();

        }
        public FrmRecipesDetails(int id)
        {
            InitializeComponent();
            _id = id;
            _service = new Recipes_Services();
        }

        private void FrmRecipesDetails_Load(object sender, EventArgs e)
        {
            string productName = "";
            List<Recipes.Model.Model.productTeste> lista = _service.GetAllProducts();
            foreach (var item in lista)
            {
                if (item.productID == _id)
                    productName = item.productName;
            }
            //lblProductName.Text = productName;
        }

    }
}
