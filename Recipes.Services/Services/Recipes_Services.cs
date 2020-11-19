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

        public Recipes_Services()
        {
            _repo = new RecipesRepository();
        }

        // Criar validações necessárias (regras de negócio)

        public List<Recipe> GetALL()
        {
            return _repo.GetALL();             
        }

        public List<productTeste> GetAllProducts()
        {
            return _repo.GetAllProducts();
        }



        public Recipe GetById(int id)
        {
            return _repo.GetById(id);
        }

        public void Add(Recipe recipe)
        {
            _repo.Add(recipe);
        }

        public void Update(Recipe recipe)
        {
            _repo.Update(recipe);
        }

        public void Remove(int id)
        {
            _repo.Remove(id);
        }


    }
}
