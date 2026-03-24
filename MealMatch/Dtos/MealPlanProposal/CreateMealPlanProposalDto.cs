namespace MealMatch.Dtos.MealPlanProposal;

public record class CreateMealPlanProposalDto
{
    public int? MealId { get; init; }
    public bool? BeBad { get; init; }   
}
