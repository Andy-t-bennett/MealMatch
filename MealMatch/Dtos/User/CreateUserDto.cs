using System.ComponentModel.DataAnnotations;

namespace MealMatch.Dtos.User;

public record class CreateUserDto
{
    [Required]
    [StringLength(100, MinimumLength = 1)]
    public string? Name { get; init; }
}
