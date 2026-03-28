using Microsoft.EntityFrameworkCore;

namespace MealMatch.Models;

public class MealIngredient
{
    public int Id { get; set; }
    
    public int IngredientId { get; set; }
    
    public required Ingredient Ingredient { get; set; }
    
    public required string Measurement { get; set; }

    [Precision(4, 2)]
    public decimal Amount { get; set; }
    
    public int MealId { get; set; } 
    
    public required Meal Meal { get; set; }
}
