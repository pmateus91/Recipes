using Recipes.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recepies.Data.Repositories
{
    public class AccountRepository
    {
        public List<Account> GetALL()
        {
            return null;
        }
        public Account GetById(int id)
        {
            return null;
        }
        public void Add(Account account)
        {

        }
        public void Update(Account account)
        {

        }
        public void Remove(int id)
        {

        }
        public int ValidateAccount (string username, string password)
        {
            //if()
            return 1;
            throw new Exception("Invalid");       
        }
    }
}
