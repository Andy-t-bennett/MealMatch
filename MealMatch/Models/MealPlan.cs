namespace MealMatch.Models;

public class MealPlan
{
    public int Id { get; set; }

    public int Weeks { get; set; }

    public bool IsCompleted { get; set; }

    public required DateOnly StartDate { get; set; }

    public required DateOnly EndDate { get; set; }

    public int HouseholdId { get; set; }

    public required Household Household { get; set; }

    public required List<MealPlanMeal> MealPlanMeals { get; set; }
}
