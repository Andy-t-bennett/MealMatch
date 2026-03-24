using System.ComponentModel.DataAnnotations;

namespace MealMatch.Dtos.Meal;

public record class CreateMealDto
{
    [Required]
    [StringLength(100, MinimumLength = 1)]
    public string? Name { get; init; }
}
