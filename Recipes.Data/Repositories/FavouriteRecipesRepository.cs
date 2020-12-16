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
    public class FavouriteRecipesRepository
    {
        public List<FavouriteRecipe> GetALL(int id)
        {
            List<FavouriteRecipe> temp = new List<FavouriteRecipe>();

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr))
            {
                SqlCommand cmd = new SqlCommand("spGetAll_FavouriteRecipe", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserID", id);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    FavouriteRecipe favouriteRecipe = new FavouriteRecipe()
                    {
                        RecipeID = dr.GetInt32(0),
                        UserID = dr.GetInt32(2),                     
                        IsFavourite = dr.GetBoolean(14)
                    };
                    temp.Add(favouriteRecipe);
                }
                conn.Close();
            }

            return temp;
        }
        public void Add(FavouriteRecipe favouriteRecipe)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spInsert_FavouriteRecipe";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@RecipeID", favouriteRecipe.RecipeID);
                cmd.Parameters.AddWithValue("@UserID", favouriteRecipe.UserID);
                cmd.Parameters.AddWithValue("@IsFavourite", favouriteRecipe.IsFavourite);

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

        public void Update(FavouriteRecipe favouriteRecipe)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spUpdate_Insert_FavouriteRecipe";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@RecipeID", favouriteRecipe.RecipeID);
                cmd.Parameters.AddWithValue("@UserID", favouriteRecipe.UserID);
                cmd.Parameters.AddWithValue("@IsFavourite", favouriteRecipe.IsFavourite);

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

                cmd.CommandText = "spRemove_FavouriteRecipe";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@RecipeID", id);

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
