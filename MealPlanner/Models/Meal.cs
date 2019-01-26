using System.ComponentModel.DataAnnotations;

namespace MealPlanner.Models
{
    public class Meal
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }
       
        [Display(Name = "Type of Meal")]
        public string MealType { get; set; }
    }
}
