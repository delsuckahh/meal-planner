using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlanner.Models
{
    public class Recipe
    {
        public string Title       { get; set; }
        public string Description { get; set; }       

        public int PrepTime    { get; set; }
        public int CookTime    { get; set; }
        public int Calories    { get; set; }
        public int NumServings { get; set; }        

        public string Course  { get; set; }
        public string Cuisine { get; set; }
        public string Author  { get; set; }

        private int    Ingredients_Quantity { get; set; }
        private string Ingredients_Unit     { get; set; }
        private string Ingredient_Item      { get; set; }

        private List<string> _ingredient = new List<string>();

        public List<string> Ingredient
        {
            get
            {

                return this._ingredient;
            }

            set
            {
                _ingredient.Add($"{Ingredients_Quantity.ToString()} {Ingredients_Unit} {Ingredient_Item}");
            }
        }

        public List<string> Instructions { get; set; }

        public int Id { get; set; }

        private int _totalTime;

        public int TotalTime
        {
            get
            {
                return this._totalTime;
            }

            set
            {
                _totalTime = PrepTime + CookTime;
            }
        }

    }
}
