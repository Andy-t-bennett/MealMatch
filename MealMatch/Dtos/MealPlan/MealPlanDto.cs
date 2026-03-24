using MealMatch.Dtos.MealPlanMeal;

namespace MealMatch.Dtos.MealPlan;

public record class MealPlanDto
{
    public int Id { get; init; }
    public int Weeks { get; init; }
    public required DateOnly StartDate { get; init; }
    public required DateOnly EndDate { get; init; }
    public required List<MealPlanMealDto> Meals {get; init; }
}
