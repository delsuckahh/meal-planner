using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlanner.Models
{
    public class Ingredient
    {
        public int ID { get; set; }
        public int RecipeID { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public string Item { get; set; }

        public virtual Recipe Recipe { get; set; }
    }
}
