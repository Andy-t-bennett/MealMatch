using MealMatch.Dtos.Meal;

namespace MealMatch.Dtos.MealPlanMeal;

public record class MealPlanMealDto
{
    public int Id { get; init; }
    public required MealDto Meal { get; init; }
    public required DateOnly Date { get; init; }
}
