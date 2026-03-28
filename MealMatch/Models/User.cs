namespace MealMatch.Models;

public class User
{
    public int Id { get; set; }
    
    public required string Name { get; set; }

    public required int? HouseholdId { get; set; }
    
    public required Household? Household { get; set; }
}
