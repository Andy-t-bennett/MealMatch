namespace MealMatch.Models;

public enum Measurement
{
    Tsp,
    Tbsp,
    Cup,
    Whole
}

public class MealIngredient
{
    public int Id { get; set; }
    public int IngredientId { get; set; }
    public required Ingredient Ingredient { get; set; }
    public required Measurement Measurement { get; set; }
    public int Amount { get; set; }
    public int MealId { get; set; } 
    //public required Meal Meal { get; set; }
}
