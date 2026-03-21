namespace MealMatch.Models;

public class MealPlanMeal
{
    public int Id { get; set; }

    public int MealId { get; set; }

    public required Meal Meal { get; set; }

    public int MealPlanId { get; set; }

    public required MealPlan MealPlan { get; set; }
    
    public required DateOnly Date { get; set; }
}
