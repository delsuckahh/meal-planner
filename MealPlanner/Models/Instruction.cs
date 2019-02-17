namespace MealPlanner.Models
{
    public class Instruction
    {
        public int ID { get; set; }
        public int RecipeID { get; set; }
        public int StepNum { get; set; }
        public string Description { get; set; }

        public virtual Recipe Recipe { get; set; }
    }
}