using Recipes.Model.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Data.Repositories
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
            using(SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr))
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "spAddUser";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                cmd.Parameters.AddWithValue("@LastName", user.LastName);
                cmd.Parameters.AddWithValue("@Gender", user.Gender);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Address", user.Address);
                cmd.Parameters.AddWithValue("@IsAdmin", user.IsAdmin);
                cmd.Parameters.AddWithValue("@IsBlocked", user.IsBlocked);
                cmd.Parameters.AddWithValue("@Account", user.Account);
                SqlParameter idParam = new SqlParameter();
                idParam.ParameterName = "@RecipeID";
                idParam.SqlDbType = SqlDbType.Int;
                idParam.Direction = ParameterDirection.Output; // output

                cmd.Parameters.Add(idParam);

                conn.Open();

                int affectedRows = cmd.ExecuteNonQuery();

                if (affectedRows == 1)
                {
                    int id = (int)idParam.Value;

                    user.Id = id;
                }
                else
                {
                    throw new Exception("Não foi possivel inserir");
                }
            }
        }
        public void Update(User user)
        {

        }
        public void Remove(int id)
        {

        }

        public void UpdateBlockedStatus(User user)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spUpdateBlockedUser";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IsBlocked", user.IsBlocked);

                conn.Open();

                int affectedRows = cmd.ExecuteNonQuery();

                if (affectedRows != 1)
                {
                    throw new Exception("Não foi possivel alterar os dados");
                }
            }
        }
    }
}
