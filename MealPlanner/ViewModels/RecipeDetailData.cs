using System.Collections.Generic;
using MealPlanner.Models;

namespace MealPlanner.ViewModels
{
    public class RecipeDetailData
    {
        public IEnumerable<Recipe> Recipes { get; set; }
        public IEnumerable<Ingredient> Ingredients { get; set; }
        public IEnumerable<Instruction> Instructions { get; set; }

    }
}