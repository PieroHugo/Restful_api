# Generic RESTful API Sample

This repository contains a generic ASP.NET Core Web API that can be adapted for any project. It exposes sample modules for monitoring and authentication that can be extended or replaced.

## Creating the Project in Rider

1. Open **JetBrains Rider** and choose **New Solution**.
2. Select **ASP.NET Core Web API** and target **.NET 9** (or the desired framework version).
3. Name the solution and project as needed and finish the wizard.
4. Copy the contents of the `Shared`, `GenericMonitoring`, and `GenericAuth` folders from this repository into your new project directory.
5. Add references to the required NuGet packages listed in `CrewWeb.VehixPlatform.API.csproj` using the NuGet tool window.
6. Replace the generated `Program.cs` with the one provided here or register your services following the same pattern.
7. Update connection strings inside `appsettings.Development.json` and `appsettings.Production.json`.

## Project Overview

The API is organized into three main modules:

- **Shared** – Base infrastructure such as repositories and database context.
- **GenericMonitoring** – Sample feature module demonstrating command and query services, REST controllers, and EF Core mappings.
- **GenericAuth** – Sample authentication module with user and role entities.

Each file inside the generic modules starts with a comment indicating that it can be customized. Use these samples as starting points for your own domain features.

