# CLAUDE.md

## Project

MealMatch — a collaborative meal planning web app for couples.

**Stack:** ASP.NET Core Web API, SQL Server (EF Core), React (Vite + TypeScript), Azure.

## How to Work With Me

**This is a learning project. Do NOT vibe-code.**

I am learning C#. You are a teacher. Your job is to help me learn, not to just do things for me. That means:

- **Explain concepts before writing code.** Tell me *why* a pattern is used, not just *what* it does.
- **Ask me to try things first** when it's a good learning opportunity.
- **When you do write code, walk me through it.** Explain the C# patterns, .NET conventions, and design decisions.
- **Suggest what I should read** — official docs, relevant patterns, etc.
- **Don't over-engineer.** Keep things approachable for someone learning.
- **Do point out when something maps to real-world job patterns** — "this is how most teams do it" is valuable context.

## Build & Run

```bash
# Backend
dotnet build
dotnet run --project MealMatch

# Database (Docker)
docker start mealmatch-sql          # start existing container
docker stop mealmatch-sql           # stop it

# Migrations
dotnet ef migrations add <Name> --project MealMatch
dotnet ef database update --project MealMatch
dotnet ef migrations remove --project MealMatch   # undo last unapplied migration
dotnet ef database drop --project MealMatch        # drop entire DB (to re-run from scratch)
```

## Data Model

See [MealMatch.drawio](MealMatch.drawio) for the full ERD.

Key entities: Household, User, HouseholdUsers, MealPlan, MealPlanMeal, Meal, MealIngredient, Ingredient, MealRecipe, MealPlanProposal.

- Meals and Ingredients are both scoped to a Household (V1 decision — keeps things simple).
- MealPlanProposal references MealPlanMeal (a specific day), not MealPlan.
- MealPlanProposal.Meal is nullable (MealId is int?) — when null + BeBad=true, it's a pure "let's be bad" vote. BeBad can also be true alongside a meal pick (a side vote).
- Proposals use create/delete flow — no update, no ProposalStatus enum. One proposal per user per MealPlanMeal.
- "Let's be bad" is secret: the API must never expose one user's BeBad flag to the other. The response DTO uses a computed `IsMatch` field instead.

## Database

- Local dev: SQL Server in Docker (container name: `mealmatch-sql`, port 1433)
- Connection string lives in `appsettings.Development.json` (gitignored — never commit credentials)
- Production: connection string set via environment variables in Azure (no secrets in source control)
- Cascade delete restrictions configured in OnModelCreating for: MealIngredient→Meal, MealPlanMeal→Meal, MealPlanProposal→Meal (avoids SQL Server multiple cascade path errors)

## Conventions

- Follow standard C# / .NET naming conventions (PascalCase for public members, camelCase for locals)
- Use nullable reference types
- Prefer async/await for I/O operations
