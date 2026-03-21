# MealMatch — Progress Tracker

## Done
- [x] Project scaffolding (ASP.NET Core Web API)
- [x] Data model design (ERD)
- [x] All models created and reviewed
  - Household, User, HouseholdUser
  - Ingredient (household-scoped)
  - Meal, MealIngredient, MealRecipe
  - MealPlan, MealPlanMeal, MealPlanProposal
- [x] DbContext — EF Core setup with cascade delete restrictions (MealIngredient, MealPlanMeal, MealPlanProposal)
- [x] Database — SQL Server in Docker, connection string in appsettings.Development.json (gitignored)
- [x] Initial migration applied successfully
- [x] Added ProposalStatus enum (Active, Countered, Accepted) to MealPlanProposal
- [x] Added navigation lists: MealPlan → MealPlanMeals, Meal → MealIngredients

## Up Next
- [ ] DTOs — define request/response models (keeps BeBad hidden, controls what the API exposes)
- [ ] API Controllers + endpoints (start simple: Household, User, then Meals, then Proposals)
- [ ] Seed data — a few households/meals to work with locally

## Backlog (Backend)
- [ ] Repositories or Services layer
- [ ] MealPlanProposal BeBad secret logic
- [ ] Auth (users, login)
- [ ] Unit + integration tests

## Backlog (Frontend)
- [ ] React app setup (Vite + TypeScript)
- [ ] Meal browsing / management UI
- [ ] Meal plan builder UI
- [ ] Proposal / voting UI (the fun part)

## Design Decisions Made
- Ingredients are household-scoped for V1 (no global shared ingredients)
- Meals are household-scoped (no universal meal sharing for V1)
- "Let's be bad" is secret — API must never expose one user's BeBad flag until both match
- MealPlanProposal references MealPlanMeal (a day slot), not MealPlan directly
