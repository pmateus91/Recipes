using Recipes.Data.Repositories;
using Recipes.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Services.Services
{
    public class RecipesIngredients_Services
    {
        RecipeIngredientsRepository _repoRecipeIngredients;

        public RecipesIngredients_Services()
        {
            _repoRecipeIngredients = new RecipeIngredientsRepository();
        }
        public void Add(RecipeIngredient recipeIngredient)
        {
            _repoRecipeIngredients.Add(recipeIngredient);
        }

    }

}
