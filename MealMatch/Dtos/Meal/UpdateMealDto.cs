using System.ComponentModel.DataAnnotations;

namespace MealMatch.Dtos.Meal;

public record class UpdateMealDto
{
    [Required]
    [StringLength(100, MinimumLength = 1)]
    public string? Name { get; init; }

    public string? Recipe { get; init; }
}
