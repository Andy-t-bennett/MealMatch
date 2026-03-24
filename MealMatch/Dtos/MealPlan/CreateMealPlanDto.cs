using System.ComponentModel.DataAnnotations;

namespace MealMatch.Dtos.MealPlan;

public record class CreateMealPlanDto
{
    [Required]
    public int? Weeks { get; init; }
    [Required]
    public DateOnly? StartDate { get; init; }
    [Required]
    public DateOnly? EndDate { get; init; }
}
