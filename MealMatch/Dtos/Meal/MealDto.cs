using MealMatch.Dtos.MealIngredient;
using MealMatch.Dtos.MealRecipe;

namespace MealMatch.Dtos.Meal;

public record class MealDto
{
    public int Id { get; init; }
    public required string Name { get; init; }
    public required List<MealRecipeDto> Recipe { get; init; }
    public required List<MealIngredientDto> Ingredients { get; init; }
}
