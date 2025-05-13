# FluentValidationDemo

A minimal ASP.NET Core Web API project demonstrating the use of [FluentValidation](https://fluentvalidation.net/) for model validation and [Swashbuckle](https://github.com/domaindrivendev/Swashbuckle.AspNetCore) for Swagger/OpenAPI documentation.

## Features

- .NET 8 Web API
- Model validation using FluentValidation
- Interactive API documentation with Swagger UI

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

### Running the Application

1. Clone the repository.
2. Restore dependencies:
3. Build and run the project:
4. Open your browser and navigate to `https://localhost:5001/swagger` to view the Swagger UI.

## Project Structure

- `Models/` - Contains data models (e.g., `Product`)
- `Validators/` - Contains FluentValidation validators (e.g., `ProductValidator`)
- `Program.cs` - Configures services and middleware

## Packages Used

- [FluentValidation](https://www.nuget.org/packages/FluentValidation/)
- [Swashbuckle.AspNetCore](https://www.nuget.org/packages/Swashbuckle.AspNetCore/)

## License

This project is licensed under the MIT License.
