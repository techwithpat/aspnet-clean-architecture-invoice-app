## Overview
This project is a Web API for an invoicing app built using **Clean Architecture** principles.

## Layers
1. **Domain Layer**: Core entities (`Invoice`, `Customer`) and business logic.
2. **Application Layer**: Use cases (commands, queries) with patterns like **Mediator**, **Unit of Work**, and **Repository**.
3. **Infrastructure Layer**: Handles external dependencies (database, APIs) with an in-memory database using Entity Framework Core.
4. **Presentation Layer**: Exposes API endpoints using ASP.NET Core.

## Features
- **POST /invoices**: Add a new invoice.
- **GET /invoices**: Retrieve all invoices.

## How to Use
1. Clone, restore, build, and run the project.
   ```
   git clone <repository_url>
   dotnet restore
   dotnet build
   dotnet run --project Invoicing.Api
   ```
2. Test using predefined endpoints.

## Benefits
- Clean separation of concerns.
- Flexible to changes in dependencies.
- Supports unit and integration testing.