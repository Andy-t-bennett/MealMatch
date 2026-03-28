namespace MealMatch.Models;

public class Meal
{
    public int Id { get; set; }

    public required string Name { get; set; }
    
    public string? Recipe { get; set; }

    public int HouseholdId { get; set; }

    public required Household Household { get; set; }

    public List<MealIngredient>? MealIngredients { get; set; }
}
