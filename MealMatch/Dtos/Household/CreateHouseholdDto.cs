using System.ComponentModel.DataAnnotations;

namespace MealMatch.Dtos.Household;

public record class CreateHouseholdDto
{
    [Required]
    [StringLength(100, MinimumLength = 1)]
    public string? Name { get; init; }
}
