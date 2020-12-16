using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Model.Model
{
    public class RecipeIngredient
    {
        public int RecipeID { get; set; }
        public string RecipeName { get; set; }
        public int IngredientID { get; set; }
        public string IngredientName { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; }
    }
}
