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

_Coming soon — project is in early development._

## Purpose

This is a learning project for building production-quality C# applications with a Microsoft-ecosystem stack.
