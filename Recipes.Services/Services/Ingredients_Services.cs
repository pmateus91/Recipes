using Recipes.Data.Repositories;
using Recipes.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Services.Services
{
    public class Ingredients_Services
    {
        private IngredientsRepository _repo;

        public Ingredients_Services()
        {
            _repo = new IngredientsRepository();
        }

        // Criar validações necessárias (regras de negócio)

        public List<Ingredient> GetALL()
        {
            return _repo.GetALL();
        }    

        public List<Ingredient> GetById(int id)
        {
            return _repo.GetById(id);
        }
        public void Add(Ingredient ingredient)
        {
            _repo.Add(ingredient);

        }

        public void Update(Ingredient ingredient)
        {
            _repo.Update(ingredient);
        }

        public void Remove(int id)
        {
            _repo.Remove(id);
        }

    }
}
