using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MealPlanner.Models;

namespace MealPlanner.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<MealPlanner.Models.Recipe> Recipe { get; set; }        
        public DbSet<MealPlanner.Models.Instruction> Instruction { get; set; }
        public DbSet<MealPlanner.Models.Ingredient> Ingredient { get; set; } 
    }
}
