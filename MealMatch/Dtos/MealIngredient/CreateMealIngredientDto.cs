using System.ComponentModel.DataAnnotations;
using MealMatch.Models;

namespace MealMatch.Dtos.MealIngredient;

public record class CreateMealIngredientDto
{
    [Required]
    public int? IngredientId { get; init; }
    [Required]
    public Measurement Measurement { get; init; }
    [Required]
    public decimal? Amount { get; init; }
}
