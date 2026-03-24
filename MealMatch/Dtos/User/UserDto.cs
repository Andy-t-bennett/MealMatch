namespace MealMatch.Dtos.User;

public record class UserDto
{
    public int Id { get; init; }
    public required string Name { get; init; }
}
