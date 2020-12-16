using Recipes.Data.Repositories;
using Recipes.Model.Model;
using Recipes.Model.Model.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Recipes.Services.Services
{
    public class FavouriteRecipe_Services
    {
        private FavouriteRecipesRepository _repo;
        public FavouriteRecipe_Services()
        {
            _repo = new FavouriteRecipesRepository();
        }

        public List<FavouriteRecipe> GetALL(int id)
        {
            return _repo.GetALL(id);
        }
        public void Add(FavouriteRecipe favouriteRecipe)
        {
            _repo.Add(favouriteRecipe);
        }

        public void Update(FavouriteRecipe favouriteRecipe)
        {
            _repo.Update(favouriteRecipe);
        }

        public void Remove(int id)
        {
            _repo.Remove(id);
        }
    }
}
