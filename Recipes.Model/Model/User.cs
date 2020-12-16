using Recipes.Model.Model.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Model.Model
{
    public class User /*: Account*/
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; } //enum
        public string Address { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsBlocked { get; set; }
        public string MembershipUsername { get; set; }
        //public Account Account { get; set; }
        public List<Recipe> OwnRecipes { get; set; }
        public List<Recipe> FavoriteRecipes { get; set; }
    }



}
