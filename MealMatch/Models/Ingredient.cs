namespace MealMatch.Models;

public class Ingredient
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public int HouseholdId { get; set; }
    
    public required Household Household { get; set; }
}
