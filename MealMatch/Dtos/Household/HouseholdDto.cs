using MealMatch.Dtos.User;

namespace MealMatch.Dtos.Household;

public record class HouseholdDto
{
    public int Id { get; init; }

    public required string Name { get; init; }

    public required List<UserDto> Users { get; init; }
}
