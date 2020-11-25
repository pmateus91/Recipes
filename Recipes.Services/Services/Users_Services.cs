using Recipes.Data.Repositories;
using Recipes.Model.Model;
using Recipes.Model.Model.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Services.Services
{
    public class Users_Services
    {
        private UserRepository _repoUser;

        public Users_Services()
        {
            _repoUser = new UserRepository();
        }       
   
        // Criar validações necessárias (regras de negócio)

        public List<User> GetALL()
        {           
            return _repoUser.GetALL();
        }
        public User GetById(int id)
        {
            
                //if (_repoUser.GetById(id).Gender == Gender.Male)
                //{
                //return 
                //}
                //else if (cbGender.Text == "Feminino")
                //{
                //    user.Gender = Gender.Female;
                //}
                //else
                //    user.Gender = Gender.Notknown;
            
            return _repoUser.GetById(id);
        }
        public void Add(User user, Account account)
        {                       
            _repoUser.Add(user, account);
        }
        public void Update(User user, Account account)
        {
            
            _repoUser.Update(user, account);
        }
        public void Remove(int id)
        {          
            _repoUser.Remove(id);
        }
        public void UpdateBlockedStatus(User user)
        {
            _repoUser.UpdateBlockedStatus(user);
        }

        public DataTable getUserDataTable => _repoUser.GetUserDataTable();


    }
}
