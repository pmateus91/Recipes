using Recipes.Data.Repositories;
using Recipes.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Services.Services
{
    class Comments_Services
    {


        private CommentsRepository _repo;

        public Comments_Services()
        {
            _repo = new CommentsRepository();
        }

        // Criar validações necessárias (regras de negócio)

        public List<Comment> GetALL()
        {
            return _repo.GetALL();
        }

        public List<Comment> GetById(int id)
        {
            return _repo.GetById(id);
        }
        public void Add(Comment comment)
        {
            _repo.Add(comment);

        }

        public void Update(Comment comment)
        {
            _repo.Update(comment);
        }

        public void Remove(int id)
        {
            _repo.Remove(id);
        }

    }
}
