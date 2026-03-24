namespace MealMatch.Dtos.MealRecipe;

public record class MealRecipeDto
{
    public int Id { get; init; }
    public required string Instructions { get; init; }
}
