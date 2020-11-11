using Recepies.Data.Repositories;
using Recepies.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recepies.Services.Services
{
    class CategoryService
    {
        private CategoryRepository _repo;

        public CategoryService()
        {
            _repo = new CategoryRepository();
        }

        public List<Category> GetALL()
        {
            return _repo.GetALL();
        }
        public Category GetById(int id)
        {
            return _repo.GetById(id);
        }

        public void Add(Category category)
        {
            _repo.Add(category);
        }

        public void Update(Category category)
        {

        }

        public void Remove(int id)
        {

        }
    }
}
