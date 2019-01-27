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

        public int    Ingredients_Quantity { get; set; }
        public string Ingredients_Unit     { get; set; }
        public string Ingredient           { get; set; }

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
