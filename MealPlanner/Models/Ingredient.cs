using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MealPlanner.Models
{
    public class Ingredient
    {
        public int ID { get; set; }
        public int RecipeID { get; set; }
        [Required]
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public string Item { get; set; }

        public virtual Recipe Recipe { get; set; }
    }
}