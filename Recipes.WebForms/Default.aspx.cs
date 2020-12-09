using Recipes.Model.Model;
using Recipes.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Recipes.WebForms
{
    public partial class Default : System.Web.UI.Page
    {

        private Categories_Services _service;

        protected void Page_Load(object sender, EventArgs e)
        {
            _service = new Categories_Services();
            FillCards();
        }
        #region METHODS
        private void FillCards()
        {
            FillCard1();
            FillCard2();
            FillCard3();
            FillCard4();
            FillCard5();
            FillCard6();
        }

        public void FillCard1()
        {
            foreach (var item in _service.GetById(1))
            {
                CategoryTitleLbl1.Text = item.Name;
                CategoryDescriptionLbl1.Text = item.Description;
            }
        }
        public void FillCard2()
        {
            foreach (var item in _service.GetById(2))
            {
                CategoryTitleLbl2.Text = item.Name;
                CategoryDescriptionLbl2.Text = item.Description;
            }
        }
        public void FillCard3()
        {
            foreach (var item in _service.GetById(3))
            {
                CategoryTitleLbl3.Text = item.Name;
                CategoryDescriptionLbl3.Text = item.Description;
            }
        }
        public void FillCard4()
        {
            foreach (var item in _service.GetById(4))
            {
                CategoryTitleLbl4.Text = item.Name; ;
                CategoryDescriptionLbl4.Text = item.Description;
            }
        }
        public void FillCard5()
        {
            foreach (var item in _service.GetById(5))
            {
                CategoryTitleLbl5.Text = item.Name; ;
                CategoryDescriptionLbl5.Text = item.Description;
            }
        }
        public void FillCard6()
        {
            foreach (var item in _service.GetById(7))
            {
                CategoryTitleLbl6.Text = item.Name; ;
                CategoryDescriptionLbl6.Text = item.Description;
            }
        }
        #endregion
    }
}