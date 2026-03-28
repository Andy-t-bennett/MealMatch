using System.ComponentModel.DataAnnotations;

namespace MealMatch.Dtos.MealPlanProposal;

public record class CreateMealPlanProposalDto
{
    public int? MealId { get; init; }

    [Required]
    public bool? BeBad { get; init; }   
}
