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
        public int ID { get; set; }
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }
        public Difficulty Difficulty { get; set; } //enum
        public Rating Rating { get; set; } //enum
        public string Instructions { get; set; }
        public bool Status { get; set; }
        public int User { get; set; }
        public int Category { get; set; }
        public List<Comment> Comment { get; set; }
        public List<Ingredient> Ingredient { get; set; }
    }
}
