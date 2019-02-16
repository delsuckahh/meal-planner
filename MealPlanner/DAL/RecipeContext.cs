using MealPlanner.Models;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MealPlanner.DAL
{
    public class RecipeContext : DbContext
    {
        public RecipeContext(DbContextOptions<RecipeContext> options)
            : base(options)
        {
        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Instruction> Instructions { get; set; }


    }
}
