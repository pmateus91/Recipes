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
    public class RecipeIngredientsRepository
    {
        public void Add(RecipeIngredient recipeIngredient)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spInsert_RecipeIngredients";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@RecipeID", recipeIngredient.RecipeID);
                cmd.Parameters.AddWithValue("@IngredientID", recipeIngredient.IngredientID);
                cmd.Parameters.AddWithValue("@Quantity", recipeIngredient.Quantity);
                cmd.Parameters.AddWithValue("@Unit", recipeIngredient.Unit);

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
    }
}
