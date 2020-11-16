using Recipes.Model.Model.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Model.Model
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public TimeSpan Time { get; set; }
        public Difficulty Dificulty { get; set; } //enum
        public Rating Rating { get; set; } //enum
        public string Description { get; set; }
        public bool Status { get; set; }
        public List<Category> Category { get; set; }
        public User User { get; set; }
        public List<Comment> Comment { get; set; }
        public List<Ingredient> Ingredients { get; set; }
    }
}
