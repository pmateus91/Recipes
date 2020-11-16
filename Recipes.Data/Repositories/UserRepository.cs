using Recipes.Model.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recepies.Data.Repositories
{
    public class UserRepository
    {
        public List<User> GetALL()
        {
            return null;
        }
        public User GetById(int id)
        {
            return null;
        }
        public void Add(User user)
        {
            //connection to database to insert user
            using(SqlConnection con = new SqlConnection(Properties.Settings.Default.conStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void Update(User user)
        {

        }
        public void Remove(int id)
        {

        }
       
    }
}
