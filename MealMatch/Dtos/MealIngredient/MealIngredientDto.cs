using MealMatch.Dtos.Ingredient;
using MealMatch.Models;

namespace MealMatch.Dtos.MealIngredient;

public record class MealIngredientDto
{
    public int Id { get; init; }
    public required IngredientDto Ingredient { get; init; }
    public required Measurement Measurement { get; init; }
    public required decimal Amount { get; init; }
}
