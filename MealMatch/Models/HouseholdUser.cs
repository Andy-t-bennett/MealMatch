namespace MealMatch.Models;

public class HouseholdUser
{
    public int Id { get; set; }
    public required int HouseholdId { get; set; }
    public required Household Household { get; set; }
    public required int UserId { get; set; }
    public required User User { get; set; }
}
