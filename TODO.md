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
- [x] DTOs — request/response models for all entities
  - Response DTOs nest child DTOs (no circular references)
  - Request DTOs use IDs to reference existing entities
  - BeBad never exposed in responses — server computes IsMatch instead
- [x] Removed ProposalStatus enum — proposals use create/delete flow instead of status tracking

## Up Next
- [ ] API Controllers + endpoints (start simple: Household, User, then Meals, then Proposals)
- [ ] Seed data — a few households/meals to work with locally

## Backlog (Backend)
- [ ] Repositories or Services layer
- [ ] MealPlanProposal BeBad/IsMatch logic (server-side matching)
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
- Proposals use create/delete (no update) — simpler than tracking status transitions
- BeBad is a flag on any proposal (can coexist with a meal pick) — both a meal proposal and a "side vote" to be bad
- One proposal per user per MealPlanMeal
