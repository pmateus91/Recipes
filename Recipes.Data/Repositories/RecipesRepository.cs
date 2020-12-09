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
    public class RecipesRepository
    {
        // Código ADO.NET
        public List<Recipe> GetALL()
        {
            List<Recipe> temp = new List<Recipe>();

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr))
            {
                SqlCommand cmd = new SqlCommand("spGetAll_Recepie", conn);
                //SqlCommand cmd = conn.CreateCommand();
                //cmd.CommandText = "spSearchRecipe";
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Recipe recipe = new Recipe()
                    {
                        ID = dr.GetInt32(0),
                        Category = dr.GetInt32(1),
                        User = dr.GetInt32(2),
                        Title = dr.GetString(3),
                        Duration = dr.GetTimeSpan(4),
                        Difficulty = (Difficulty)dr.GetInt32(5),
                        Instructions = dr.GetString(6),
                        Status = dr.GetBoolean(7)
                    };
                    temp.Add(recipe);
                }
                conn.Close();
            }
            
            return temp;
        }


        public Recipe GetById(int id)
        {
            return null;
        }

        public void Add(Recipe recipe)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spInsert_Recipe";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CategoryID", recipe.Category);
                cmd.Parameters.AddWithValue("@UserID", 1);
                cmd.Parameters.AddWithValue("@Title", recipe.Title);
                cmd.Parameters.AddWithValue("@Duration", recipe.Duration);
                cmd.Parameters.AddWithValue("@Difficulty", recipe.Difficulty);
                cmd.Parameters.AddWithValue("@Instructions", recipe.Instructions);
                cmd.Parameters.AddWithValue("@Status", recipe.Status);
              
                // output
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

                    recipe.ID = id;
                }
                else
                {
                    throw new Exception("Não foi possivel inserir");
                }

            }
        }

        public void Update(Recipe recipe)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spUpdateRecipe";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CategoryID", recipe.Category);
                cmd.Parameters.AddWithValue("@IngredientsID", recipe.Ingredient);
                cmd.Parameters.AddWithValue("@UserID", recipe.User);
                cmd.Parameters.AddWithValue("@Title", recipe.Title);
                cmd.Parameters.AddWithValue("@Duration", recipe.Duration);
                cmd.Parameters.AddWithValue("@Difficulty", recipe.Difficulty);
                cmd.Parameters.AddWithValue("@Instructions", recipe.Instructions);
                cmd.Parameters.AddWithValue("@Status", recipe.Status);

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
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spRemoveRecipe";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@RecipeId", id);

                conn.Open();

                int affectedRows = cmd.ExecuteNonQuery();

                if (affectedRows != 1)
                {
                    throw new Exception("Não foi possivel Eliminar");
                }
            }

        }

        //public List<RecipeIngredient> GetAllProducts()
        //{
        //    List<RecipeIngredient> temp = new List<RecipeIngredient>();

        //    using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conNorth))
        //    {
        //        SqlCommand cmd = new SqlCommand("uspGetAll", conn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        conn.Open();
        //        SqlDataReader dr = cmd.ExecuteReader();

        //        while (dr.Read())
        //        {
        //            RecipeIngredient product = new RecipeIngredient()
        //            {
        //                productID = Convert.ToInt32(dr["ProductID"].ToString()),
        //                supplierID = Convert.ToInt32(dr["SupplierID"].ToString()),
        //                productName = dr["ProductName"].ToString(),
        //                categoryId = Convert.ToInt32(dr["CategoryID"].ToString())
        //            };
        //            temp.Add(product);
        //        }
        //    }
        //    return temp;
        //}

        public DataTable GetRecipeDataTable()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr))
            {
                SqlCommand cmd = new SqlCommand("spGetAll_Recipe_Ingredients", conn);
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
