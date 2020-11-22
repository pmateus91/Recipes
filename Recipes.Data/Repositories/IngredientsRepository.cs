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
    public class IngredientsRepository
    {
        public List<Ingredient> GetALL()
        {
            List<Ingredient> temp = new List<Ingredient>();

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr))
            {
                SqlCommand cmd = new SqlCommand("spGetAll_Ingredient", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Ingredient ingredient = new Ingredient()
                    {
                        ID = dr.GetInt32(0),
                        Name = dr.GetString(1),
                        Description = dr.GetString(2)                       
                    };
                    temp.Add(ingredient);
                }
                conn.Close();
            }
            return temp;
        }
        public List<Ingredient> GetById(int id)
        {
            List<Ingredient> temp = new List<Ingredient>();

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr))
            {
                SqlCommand cmd = new SqlCommand("spGetById_Ingredient", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IngredientID", id);
                
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Ingredient ingredient = new Ingredient()
                    {
                        ID = dr.GetInt32(0),
                        Name = dr.GetString(1),
                        Description = dr.GetString(2)
                    };
                    temp.Add(ingredient);
                }
                conn.Close();
            }
            return temp;
        }
        public void Add(Ingredient ingredient)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr))
            {
                SqlCommand cmd = new SqlCommand("spInsert_Ingredient",conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IngredientName", ingredient.Name);
                cmd.Parameters.AddWithValue("@IngredientDescription", ingredient.Description);

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


                //// output
                //SqlParameter idParam = new SqlParameter();
                //idParam.ParameterName = "@IngredientID";
                //idParam.SqlDbType = SqlDbType.Int;
                //idParam.Direction = ParameterDirection.Output; // output

                //cmd.Parameters.Add(idParam);

                //conn.Open();

                //int affectedRows = cmd.ExecuteNonQuery();

                //if (affectedRows == 1)
                //{
                //    int id = (int)idParam.Value;

                //    ingredient.Id = id;
                //}
                //else
                //{
                //    throw new Exception("Não foi possivel inserir");
                //}
            }
        }
        public void Update(Ingredient ingredient)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr))
            {
                SqlCommand cmd = new SqlCommand("spUpdate_Ingredient", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IngredientID", ingredient.ID);
                cmd.Parameters.AddWithValue("@IngredientName", ingredient.Name);
                cmd.Parameters.AddWithValue("@IngredientDescription", ingredient.Description);
                
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
                SqlCommand cmd = new SqlCommand("spRemove_Ingredient", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IngredientID", id);                

                conn.Open();

                int affectedRows = cmd.ExecuteNonQuery();

                if (affectedRows != 1)
                {
                    throw new Exception("Não foi possivel alterar os dados");
                }

                // DBCC CHECKIDENT('table',RESEED,ID-1) alterar a seed do ID
            }
        }
    }
}
