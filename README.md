# Expense Tracker

A simple expense tracking application with ASP.NET Core API and Blazor WebAssembly frontend.

## Features

- Track expenses with categories: Food, Supermarket, CarFuel, Health, Technology, House, Tools
- Each expense has value, date, and description
- CRUD operations via API

## Setup

### Backend

1. Navigate to `backend` folder
2. Run `dotnet restore`
3. Run `dotnet ef database update` to create the SQLite database
4. Run `dotnet run` to start the API on http://localhost:5000

### Frontend

1. Navigate to `frontend` folder
2. Run `dotnet restore`
3. Run `dotnet run` to start the Blazor app

## Deployment

### Backend (Heroku)

1. Create a Heroku app
2. Set buildpack to .NET Core
3. Push the backend code
4. Add environment variable for production database if needed

### Frontend (Netlify)

1. Build the frontend: `dotnet publish -c Release`
2. Deploy the `wwwroot` folder to Netlify

For free deployment, use Heroku for backend and Netlify for frontend.
