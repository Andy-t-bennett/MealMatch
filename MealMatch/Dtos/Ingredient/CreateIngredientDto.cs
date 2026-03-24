using System.ComponentModel.DataAnnotations;

namespace MealMatch.Dtos.Ingredient;

public record class CreateIngredientDto
{
    [Required]
    [StringLength(100, MinimumLength = 1)]
    public string? Name { get; init; }
}
