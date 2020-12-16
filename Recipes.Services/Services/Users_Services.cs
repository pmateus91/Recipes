using Recipes.Data.Repositories;
using Recipes.Model.Model;
using Recipes.Model.Model.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;

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
        public User GetByUserMembership(string membershipUsername)
        {
            return _repoUser.GetByUserMembership(membershipUsername);
        }
        public User GetById(int id)
        {
            return _repoUser.GetById(id);
        }

        //public void Add(User user, Account account)
        //{
        //    _repoUser.Add(user, account);

            //MembershipCreateStatus status;
            //Membership.CreateUser(
            //    user.Account.UserName,
            //    user.Account.Password,
            //    user.Email,
            //    user.Account.Question,
            //    user.Account.Answer,
            //    true,
            //    out status);

            //if (status == MembershipCreateStatus.Success)
            //{
            //    user.Account.User = user;
            //    _repoUser.Add(user);
            //    _accountRepo.Add(user.Account);
            //    _userRepo.Update(user);
            //    UserMap.MapDomainToDto(user, obj);
        //    //}
        //}

        public void Add(User user)
        {
            //user.MembershipUsername = membershipUsername;
            _repoUser.Add(user);
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
