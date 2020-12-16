using Recipes.Model.Model;
using Recipes.Model.Model.Utils;
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
            List<User> temp = new List<User>();

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr))
            {
                SqlCommand cmd = new SqlCommand("spGetAll_User_Account", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Account account = new Account();
                    User user = new User()
                    {
                        ID = dr.GetInt32(0),
                        FirstName = dr.GetString(1),
                        LastName = dr.GetString(2),
                        Gender = (Gender)dr.GetByte(3),
                        Address = dr.GetString(4),
                        IsAdmin = dr.GetBoolean(5),
                        IsBlocked = dr.GetBoolean(6),
                        MembershipUsername = dr.GetString(7)

                    };                 

                    temp.Add(user);
                }
                conn.Close();
            }
            return temp;
        }
        public User GetById(int id)
        {
            //Account account = null;                
            User user = null;
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr))
            {
                SqlCommand cmd = new SqlCommand("spGetById_User", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserID", id);

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    user = new User()
                    {
                        ID = dr.GetInt32(0),
                        FirstName = dr.GetString(2),
                        LastName = dr.GetString(3),
                        Gender = (Gender)dr.GetByte(4),
                        Address = dr.GetString(6),
                        IsAdmin = dr.GetBoolean(7),
                        IsBlocked = dr.GetBoolean(8),
                        //AccountID = dr.GetInt32(9),
                        //Username = dr.GetString(10),
                        //Password = dr.GetString(11)                        
                    };
                    //user.Account = new Account();
                    //////user.Account = account;
                    //user.Account.AccountID = dr.GetInt32(9);
                    //user.Account.Username = dr.GetString(10);
                    //user.Account.Password = dr.GetString(11);
                }
                return user;
            }
        }

        public User GetByUserMembership(string membershipUsername)
        {
            User user = null;
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr))
            {
                SqlCommand cmd = new SqlCommand("spGetByMembershipUsername_User", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MembershipUsername", membershipUsername);

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    user = new User()
                    {
                        ID = dr.GetInt32(0),
                        FirstName = dr.GetString(1),
                        LastName = dr.GetString(2),
                        Gender = (Gender)dr.GetByte(3),
                        Address = dr.GetString(4),
                        IsAdmin = dr.GetBoolean(5),
                        IsBlocked = dr.GetBoolean(6),
                        MembershipUsername = dr.GetString(7)                                         
                    };
                }
                return user;
            }
        }

        //public void Add(User user, Account account)
        //{
        //    using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr))
        //    {
        //        SqlCommand cmd = conn.CreateCommand();
        //        cmd.CommandText = "spInsert_User_Account";
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        cmd.Parameters.AddWithValue("@Username", account.Username);
        //        cmd.Parameters.AddWithValue("@Password", account.Password);
        //        cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
        //        cmd.Parameters.AddWithValue("@LastName", user.LastName);
        //        cmd.Parameters.AddWithValue("@Gender", user.Gender);
        //        cmd.Parameters.AddWithValue("@Address", user.Address);
        //        cmd.Parameters.AddWithValue("@IsAdmin", user.IsAdmin);
        //        cmd.Parameters.AddWithValue("@IsBlocked", user.IsBlocked);

        //        conn.Open();

        //        try
        //        {
        //            cmd.ExecuteNonQuery();
        //        }
        //        catch (SqlException)
        //        {
        //            throw new Exception("Não foi possivel inserir");
        //        }
        //        finally
        //        {
        //            conn.Close();
        //        }
        //    }
        //}

        public void Add(User user)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr))
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "spInsert_User";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                cmd.Parameters.AddWithValue("@LastName", user.LastName);
                cmd.Parameters.AddWithValue("@Gender", user.Gender);              
                cmd.Parameters.AddWithValue("@Address", user.Address);
                cmd.Parameters.AddWithValue("@IsAdmin", user.IsAdmin);
                cmd.Parameters.AddWithValue("@IsBlocked", user.IsBlocked);
                cmd.Parameters.AddWithValue("@MembershipUsername", user.MembershipUsername);

                conn.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw new Exception("Não foi possivel inserir");
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public void Update(User user, Account account)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr))
            {
                SqlCommand cmd = new SqlCommand("spUpdate_User_Account", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AccountID", account.AccountID);
                cmd.Parameters.AddWithValue("@Username", account.Username);
                cmd.Parameters.AddWithValue("@Password", account.Password);
                cmd.Parameters.AddWithValue("@UserID", user.ID);
                cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                cmd.Parameters.AddWithValue("@LastName", user.LastName);
                cmd.Parameters.AddWithValue("@Gender", user.Gender);
                //cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Address", user.Address);
                cmd.Parameters.AddWithValue("@IsAdmin", user.IsAdmin);
                cmd.Parameters.AddWithValue("@IsBlocked", user.IsBlocked);

                conn.Open();

                int affectedRows = cmd.ExecuteNonQuery();

                if (affectedRows != 2)
                {
                    throw new Exception("Não foi possivel alterar os dados");
                }
            }
        }
        public void Remove(int id)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr))
            {
                SqlCommand cmd = new SqlCommand("spRemove_User_Account", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserID", id);

                conn.Open();

                int affectedRows = cmd.ExecuteNonQuery();

                if (affectedRows != 2)
                {
                    throw new Exception("Não foi possivel alterar os dados");
                }

                // DBCC CHECKIDENT('table',RESEED,ID-1) alterar a seed do ID
            }
        }
        public void UpdateBlockedStatus(User user)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spUpdateBlockedUser";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserID", user.ID);
                cmd.Parameters.AddWithValue("@IsBlocked", user.IsBlocked);

                conn.Open();

                int affectedRows = cmd.ExecuteNonQuery();

                if (affectedRows != 1)
                {
                    throw new Exception("Não foi possivel alterar os dados");
                }
            }
        }

        public DataTable GetUserDataTable()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr))
            {
                SqlCommand cmd = new SqlCommand("spGetAll_User_Account", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
                conn.Close();
            }
            return dt;
        }
    }
}

