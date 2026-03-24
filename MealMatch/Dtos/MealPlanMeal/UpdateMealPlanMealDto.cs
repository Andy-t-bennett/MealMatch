using System.ComponentModel.DataAnnotations;

namespace MealMatch.Dtos.MealPlanMeal;

public record class UpdateMealPlanMealDto
{
    [Required]
    public int? MealId { get; init; }
    [Required]
    public DateOnly? Date { get; init; }
}
