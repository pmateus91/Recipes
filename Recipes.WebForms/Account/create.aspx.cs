using Recipes.Model.Model;
using Recipes.Model.Model.Utils;
using Recipes.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Recipes.WebForms
{
    public partial class Register : System.Web.UI.Page
    {
        private Users_Services _service;
        protected void Page_Load(object sender, EventArgs e)
        {
            _service = new Users_Services();
        }

        protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
        {
            User user = new User();
            user.FirstName = tbFirstName.Text;
            user.LastName = tbLastName.Text;
            user.Address = tbAdress.Text;
            user.Gender = (Gender)int.Parse(ddGender.SelectedValue);
            user.IsAdmin = false;
            user.IsBlocked = false;
            user.MembershipUsername = CreateUserWizard1.UserName;

            _service.Add(user);
        }

    }
}