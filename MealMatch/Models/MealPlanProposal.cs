namespace MealMatch.Models;

public class MealPlanProposal
{
    public int Id { get; set; }
    public int MealId { get; set; }
    public Meal? Meal { get; set; }
    public int MealPlanMealId { get; set; }
    public required MealPlanMeal MealPlanMeal { get; set; }
    public int UserId { get; set; }
    public required User User { get; set; }
    public bool BeBad { get; set; }
}
