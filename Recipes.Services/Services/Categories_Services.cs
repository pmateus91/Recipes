using Recipes.Data.Repositories;
using Recipes.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Services.Services
{
    public class Categories_Services
    {
        private CategoriesRepository _repo;

        public Categories_Services()
        {
            _repo = new CategoriesRepository();
        }

        // Criar validações necessárias (regras de negócio)

        public List<Category> GetALL()
        {
            return _repo.GetALL();
        }

        public List<Category> GetById(int id)
        {
            return _repo.GetById(id);
        }

        public void Add(Category category)
        {
            _repo.Add(category);

        }

        public void Update(Category category)
        {
            _repo.Update(category);
        }

        public void Remove(int id)
        {
            _repo.Remove(id);
        }
    }
}
