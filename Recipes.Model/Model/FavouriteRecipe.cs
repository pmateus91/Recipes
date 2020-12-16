using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Model.Model
{
    public class FavouriteRecipe
    {
        public int UserID { get; set; }
        public int RecipeID { get; set; }
        public bool IsFavourite { get; set; }
    }
}
