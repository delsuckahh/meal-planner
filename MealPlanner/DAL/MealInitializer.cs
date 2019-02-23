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

            var ingredients = new List<Ingredient>();
            var instructions = new List<Instruction>();
            foreach(Recipe item in recipes)
            {
                ingredients.Add(new Ingredient { RecipeID = item.ID, Item = "Ingredient 1", });
                ingredients.Add(new Ingredient { RecipeID = item.ID, Item = "Ingredient 2", });
                instructions.Add(new Instruction { RecipeID = item.ID, StepNum = 1, Description = "Instruction 1", });
                instructions.Add(new Instruction { RecipeID = item.ID, StepNum = 2, Description = "Instruction 2", });
            }
            ingredients.ForEach(s => context.Ingredients.Add(s));
            instructions.ForEach(s => context.Instructions.Add(s));
            context.SaveChanges();

        }
    }
}