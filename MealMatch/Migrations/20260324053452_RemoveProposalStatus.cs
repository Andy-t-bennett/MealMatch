using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MealMatch.Migrations
{
    /// <inheritdoc />
    public partial class RemoveProposalStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "MealPlanProposals");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "MealPlanProposals",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
