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
    public class CategoriesRepository
    {
        public List<Category> GetALL()
        {
            List<Category> temp = new List<Category>();

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr))
            {
                SqlCommand cmd = new SqlCommand("spGetAll_Category", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Category category = new Category()
                    {
                        ID = dr.GetInt32(0),
                        Name = dr.GetString(1),
                        Description = dr.GetString(2),
                    };
                    temp.Add(category);
                }
                conn.Close();
            }
            return temp;
        }
        public List<Category> GetById(int id)
        {
            List<Category> temp = new List<Category>();

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr))
            {
                SqlCommand cmd = new SqlCommand("spGetById_Category", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoryID", id);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Category category = new Category()
                    {
                        ID = dr.GetInt32(0),
                        Name = dr.GetString(1),
                        Description = dr.GetString(2),
                    };
                    temp.Add(category);
                }
                conn.Close();
            }
            return temp;
        }
        public void Add(Category category)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr))
            {
                SqlCommand cmd = new SqlCommand("spInsert_Category", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CategoryName", category.Name);
                cmd.Parameters.AddWithValue("@CategoryDescription", category.Description);

                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    throw new Exception("Não foi possivel inserir");
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public void Update(Category category)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr))
            {
                SqlCommand cmd = new SqlCommand("spUpdate_Category", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CategoryID", category.ID);
                cmd.Parameters.AddWithValue("@CategoryName", category.Name);
                cmd.Parameters.AddWithValue("@CategoryDescription", category.Description);

                conn.Open();

                int affectedRows = cmd.ExecuteNonQuery();

                if (affectedRows != 1)
                {
                    throw new Exception("Não foi possivel alterar os dados");
                }
            }
        }
        public void Remove(int id)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr))
            {
                SqlCommand cmd = new SqlCommand("spRemove_Category", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CategoryID", id);

                conn.Open();
                int affectedRows = cmd.ExecuteNonQuery();

                if (affectedRows != 1)
                {
                    throw new Exception("Não foi possivel Eliminar");
                }
            }
        }
    }
}
