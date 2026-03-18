namespace MealMatch.Models;

public class Meal
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public List<MealRecipe>? MealRecipes { get; set; }
    public int HouseholdId { get; set; }
    public required Household Household { get; set; }
}
