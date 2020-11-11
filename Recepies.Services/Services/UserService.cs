using Recepies.Data.Repositories;
using Recepies.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recepies.Services.Services
{
    class UserService
    {
        public User ValidateAccount (string username, string password)
        {
            UserRepository userRepo = new UserRepository();

            AccountRepository accountRepo = new AccountRepository();

            try
            {
                int loggedInUserId = accountRepo.ValidateAccount(username, password);
                User user = userRepo.GetById(loggedInUserId);
                return user;

            } catch (Exception e)
            {
                return null;
            }            
        }
    }
}
