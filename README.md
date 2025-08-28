# PlacementApp

**PlacementApp** is a simple ASP.NET Core MVC web application for managing student placement applications. It allows users to create, view, edit, and delete placement records through an intuitive web interface.

## Features

- List all placement applications  
- Add a new placement application  
- Edit existing applications  
- View detailed information about each application  
- Delete placement applications  

## Technologies Used

- ASP.NET Core MVC (.NET 5)  
- Entity Framework Core (for database access)  
- Razor Views for frontend  

## Project Structure

- `Controllers/PlacementApplicationsController.cs` — handles all CRUD actions  
- `Models/PlacementApplication.cs` — model defining the placement application entity  
- `Views/PlacementApplications/` — Razor views for UI (Index, Create, Edit, Details, Delete)  

## How to Run

1. Clone this repository  
2. Restore dependencies: `dotnet restore`  
3. Run the project: `dotnet run --urls http://localhost:5000`  
4. Open a browser and navigate to `http://localhost:5000/PlacementApplications`
