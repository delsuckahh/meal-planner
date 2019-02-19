using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MealPlanner.Models;

namespace MealPlanner.DAL
{
    public class MealInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<MealContext>
    {
        protected override void Seed(MealContext context)
        {
            var recipes = new List<Recipe>
            {
                new Recipe{Title="Taco Soup",Description="Its like a taco, but in soup form",PrepTime=30,CookTime=30,Calories=1200,NumServings=4,Course="Dinner",Cuisine="Mexian",},
                new Recipe{Title="Beef Ravioli",Description="Beef stuffed into a noodle, what's not to like?",PrepTime=60,CookTime=50,Calories=2200,NumServings=4,Course="Dinner",Cuisine="Italian",}
            };
            recipes.ForEach(s => context.Recipes.Add(s));
            context.SaveChanges();
        }
    }
}