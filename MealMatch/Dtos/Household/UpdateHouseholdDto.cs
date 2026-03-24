using System.ComponentModel.DataAnnotations;

namespace MealMatch.Dtos.Household;

public record class UpdateHouseholdDto
{
    [Required]
    [StringLength(100, MinimumLength = 1)]
    public string? Name { get; init; }
}
