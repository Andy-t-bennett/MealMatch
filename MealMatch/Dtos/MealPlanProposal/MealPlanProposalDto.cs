using MealMatch.Dtos.Meal;
using MealMatch.Dtos.User;

namespace MealMatch.Dtos.MealPlanProposal;

public record class MealPlanProposalDto
{
    public int Id { get; init; }

    public MealDto? Meal { get; init; }

    public required UserDto User { get; init; }

    public required bool IsMatch { get; init; }
}
