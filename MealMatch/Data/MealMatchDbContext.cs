using MealMatch.Models;
using Microsoft.EntityFrameworkCore;

namespace MealMatch.Data;

public class MealMatchDbContext(DbContextOptions<MealMatchDbContext> options) : DbContext(options)
{
    public DbSet<Household> Households { get; set; }
    public DbSet<HouseholdUser> HouseholdUsers { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<Meal> Meals { get; set; }
    public DbSet<MealIngredient> MealIngredients { get; set; }
    public DbSet<MealPlan> MealPlans { get; set; }
    public DbSet<MealPlanMeal> MealPlanMeals { get; set; }
    public DbSet<MealPlanProposal> MealPlanProposals { get; set; }
    public DbSet<MealRecipe> MealRecipes { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MealIngredient>(entity =>
        {
            entity.HasOne(mi => mi.Meal)
                .WithMany()
                .HasForeignKey(mi => mi.MealId)
                .OnDelete(DeleteBehavior.Restrict);   
        });

        modelBuilder.Entity<MealPlanMeal>(entity =>
        {
            entity.HasOne(mpm => mpm.Meal)
                .WithMany()
                .HasForeignKey(mpm => mpm.MealId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<MealPlanProposal>(entity =>
        {
            entity.HasOne(mpp => mpp.Meal)
                .WithMany()
                .HasForeignKey(mpp => mpp.MealId)
                .OnDelete(DeleteBehavior.Restrict);
        });
    }
}
