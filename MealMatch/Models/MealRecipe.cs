namespace MealMatch.Models;

public class MealRecipe
{
    public int Id { get; set; }
    public int MealId { get; set; }
    public required Meal Meal { get; set; }
    public required string Instructions { get; set; }
}
