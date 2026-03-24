using System.ComponentModel.DataAnnotations;

namespace MealMatch.Dtos.MealRecipe;

public record class UpdateMealRecipeDto
{
    [Required]
    [StringLength(1000, MinimumLength = 1)]
    public string? Instructions { get; init; }
}
