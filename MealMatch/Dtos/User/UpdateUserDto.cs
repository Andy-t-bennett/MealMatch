using System.ComponentModel.DataAnnotations;

namespace MealMatch.Dtos.User;

public record class UpdateUserDto
{
    [Required]
    [StringLength(100, MinimumLength = 1)]
    public string? Name { get; init; }
    
    public int? HouseholdId { get; init; }
}
