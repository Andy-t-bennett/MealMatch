using MealMatch.Dtos.MealIngredient;

namespace MealMatch.Dtos.Meal;

public record class MealDto
{
    public int Id { get; init; }

    public required string Name { get; init; }

    public string? Recipe { get; init; }

    public required List<MealIngredientDto> Ingredients { get; init; }
}
