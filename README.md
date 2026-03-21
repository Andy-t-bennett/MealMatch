# MealMatch

A collaborative meal planning web app for couples. Plan your weekly meals together — propose meals, match on what sounds good, and settle "what's for dinner tonight?" without the back-and-forth.

## Features (Planned)

- **Weekly Meal Plans** — Auto-generated meal suggestions for the week
- **Meal Proposals** — Propose a meal for a given day; your partner can agree or counter-propose
- **Tonight's Dinner** — Quick flow to decide what to eat tonight from the plan
- **"Let's Be Bad" Match** — Secretly opt in to skip cooking; if both do, it's revealed (Tinder-style matching)
- **Recipes & Ingredients** — Store recipes with step-by-step instructions and ingredient lists per meal
- **Household Accounts** — Auth with household-scoped data so each couple has their own space

## Tech Stack

- **Backend:** ASP.NET Core Web API
- **Database:** SQL Server + Entity Framework Core
- **Frontend:** React (Vite + TypeScript)
- **Hosting:** Azure

## Data Model

See [MealMatch.drawio](MealMatch.drawio) for the entity relationship diagram.

**Core entities:** Household, User, MealPlan, MealPlanMeal, Meal, MealIngredient, Ingredient, MealRecipe, MealPlanProposal

## Getting Started

### Prerequisites
- .NET 8+ SDK
- Docker Desktop
- EF Core CLI: `dotnet tool install --global dotnet-ef`

### Database Setup
```bash
# Start SQL Server in Docker
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=<YourPassword>" -p 1433:1433 --name mealmatch-sql -d mcr.microsoft.com/mssql/server:2022-latest

# Copy appsettings.Development.json into MealMatch/ with your connection string
# (this file is gitignored — see appsettings.json for the structure)

# Run migrations
dotnet ef database update --project MealMatch
```

### Run the API
```bash
dotnet run --project MealMatch
```

## Purpose

This is a learning project for building production-quality C# applications with a Microsoft-ecosystem stack.
