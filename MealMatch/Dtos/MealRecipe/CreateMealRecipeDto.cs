using System.ComponentModel.DataAnnotations;

namespace MealMatch.Dtos.MealRecipe;

public record class CreateMealRecipeDto
{
    [Required]
    [StringLength(1000, MinimumLength = 1)]
    public string? Instructions { get; init; }
}
