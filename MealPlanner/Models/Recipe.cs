using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MealPlanner.Models
{
    public class Recipe
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }
        public string Description { get; set; }

        [Display(Name = "Prep Time")]
        public int PrepTime { get; set; }
        [Display(Name = "Cook Time")]
        public int CookTime { get; set; }
        public int Calories { get; set; }
        [Display(Name = "Number of servings")]
        public int NumServings { get; set; }

        public string Course { get; set; }
        public string Cuisine { get; set; }

        public virtual ICollection<Ingredient> Ingredients { get; set; }
        public virtual ICollection<Instruction> Instructions { get; set; }

        [Display(Name = "Total Time")]
        public int TotalTime
        {
            get
            {
                return PrepTime + CookTime;
            }
        }

        [Display(Name = "Calories per serving")]
        public int CaloriesPerServing
        {
            get
            {
                return Calories / NumServings;
            }
        }

        public string DummyField { get; set; }
    }
}