using MealMatch.Dtos.Ingredient;

namespace MealMatch.Dtos.MealIngredient;

public record class MealIngredientDto
{
    public int Id { get; init; }

    public required IngredientDto Ingredient { get; init; }

    public required string Measurement { get; init; }

    public required decimal Amount { get; init; }
}
