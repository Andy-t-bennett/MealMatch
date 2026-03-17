namespace MealMatch.Models;

public class Household
{
    public int Id { get; set; }
    public required List<HouseholdUser> HouseholdUsers { get; set; }
}
