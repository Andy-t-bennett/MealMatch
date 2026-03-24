using System.ComponentModel.DataAnnotations;

namespace MealMatch.Dtos.MealPlanMeal;

public record class CreateMealPlanMealDto
{
    [Required]
    public int? MealId { get; init; }
    [Required]
    public DateOnly? Date { get; init; }
}
