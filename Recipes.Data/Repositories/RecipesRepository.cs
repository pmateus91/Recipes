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
                SqlCommand cmd = new SqlCommand("spSearchRecipe", conn);
                //SqlCommand cmd = conn.CreateCommand();
                //cmd.CommandText = "spSearchRecipe";
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Recipe Recipe = new Recipe()
                    {
                        Id = dr.GetInt32(0),
                        Title = dr.GetString(1),
                        Duration = dr.GetTimeSpan(2),
                        Difficulty = (Difficulty)dr.GetByte(3),
                        Rating = (Rating)dr.GetByte(4),
                        Instructions = dr.GetString(5),
                        Status = dr.GetBoolean(6)
                    };
                    temp.Add(Recipe);
                }
                conn.Close();
            }
            
            return temp;
        }
        public List<productTeste> GetAllProducts()
        {
            List<productTeste> temp = new List<productTeste>();

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conNorth))
            {
                SqlCommand cmd = new SqlCommand("uspGetAll", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    productTeste product = new productTeste()
                    {
                        productID = Convert.ToInt32(dr["ProductID"].ToString()),
                        supplierID = Convert.ToInt32(dr["SupplierID"].ToString()),
                        productName = dr["ProductName"].ToString(),
                        categoryId = Convert.ToInt32( dr["CategoryID"].ToString())
                    };
                    temp.Add(product);
                }
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

                cmd.CommandText = "spAddRecipe";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CategoryID", recipe.Category);
                cmd.Parameters.AddWithValue("@IngredientsID", recipe.Ingredient);
                cmd.Parameters.AddWithValue("@UserID", recipe.User);
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

                    recipe.Id = id;
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
    }
}
