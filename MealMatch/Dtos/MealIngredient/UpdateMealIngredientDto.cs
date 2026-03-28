using System.ComponentModel.DataAnnotations;

namespace MealMatch.Dtos.MealIngredient;

public record class UpdateMealIngredientDto
{
    [Required]
    public int? IngredientId { get; init; }

    [Required]
    [StringLength(100, MinimumLength = 1)]
    public string? Measurement { get; init; }

    [Required]
    public decimal? Amount { get; init; }
}
