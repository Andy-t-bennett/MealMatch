namespace MealMatch.Dtos.Ingredient;

public record class IngredientDto
{
    public int Id { get; init; }

    public required string Name { get; init; }
}
