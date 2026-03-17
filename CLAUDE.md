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
```

## Data Model

See [MealMatch.drawio](MealMatch.drawio) for the full ERD.

Key entities: Household, User, HouseholdUsers, MealPlan, MealPlanMeal, Meal, MealIngredient, Ingredient, MealRecipe, MealPlanProposal.

- Meals are scoped to a Household. Ingredients are global/shared.
- MealPlanProposal references MealPlanMeal (a specific day), not MealPlan.
- MealPlanProposal.Meal is nullable — when null + BeBad=true, it's a "let's be bad" vote.
- "Let's be bad" is secret: the API must never expose one user's BeBad flag to the other until both match.

## Conventions

- Follow standard C# / .NET naming conventions (PascalCase for public members, camelCase for locals)
- Use nullable reference types
- Prefer async/await for I/O operations
