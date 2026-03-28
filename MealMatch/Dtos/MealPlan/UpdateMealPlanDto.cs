using System.ComponentModel.DataAnnotations;

namespace MealMatch.Dtos.MealPlan;

public record class UpdateMealPlanDto
{
    [Required]
    public DateOnly? StartDate { get; init; }
    
    [Required]
    public DateOnly? EndDate { get; init; }
}
