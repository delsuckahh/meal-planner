using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MealPlanner.Models
{
    public class MealPlannerContext : DbContext
    {
        public MealPlannerContext (DbContextOptions<MealPlannerContext> options)
            : base(options)
        {
        }

        public DbSet<MealPlanner.Models.Recipe> Recipe { get; set; }
    }
}
