using System;
using System.Collections.Generic;
using Recipes.Model.Model;
using Recipes.Data.Repositories;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Recipes.Services.Services
{
    public class Recipes_Services
    {

        private RecipesRepository _repo;
        Recipe _recipe = new Recipe();


        public Recipes_Services()
        {
            _repo = new RecipesRepository();
        }

        // Criar validações necessárias (regras de negócio)

        public List<Recipe> GetALL()
        {
            return _repo.GetALL();             
        }
        public List<Recipe> GetALLValidated()
        {
            return _repo.GetALLValidated();
        }
        public List<Recipe> GetByID(int id)
        {
            if (_recipe.Rating.ToString() == null)
            {
                _recipe.Rating = 0;
            }
            return _repo.GetByID(id);
        }

        public List<Recipe> GetRecipeByCategoryID(int id)
        {
            return _repo.GetRecipeByCategoryID(id);
        }
        public List<Recipe> GetRecipeByUserID(int id)
        {
            return _repo.GetRecipeByUserID(id);
        }
        public List<Recipe> GetALLFavourite(int id)
        {
            return _repo.GetALLFavourite(id);
        }
        public void Add(Recipe recipe)
        {
            recipe.Status = false;
            _repo.Add(recipe);
        }

        public void Update(Recipe recipe)
        {
            _repo.Update(recipe);
        }
        public void UpdateStatus(Recipe recipe)
        {
            _repo.UpdateStatus(recipe);
        }

        public void UpdateFavourite(Recipe recipe)
        {
            _repo.Update(recipe);
        }

        public void Remove(int id)
        {
            _repo.Remove(id);
        }


    }
}
