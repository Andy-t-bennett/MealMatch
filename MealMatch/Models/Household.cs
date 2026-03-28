namespace MealMatch.Models;

public class Household
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public required List<User> Users { get; set; }
}
