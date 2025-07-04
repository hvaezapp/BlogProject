# BlogProject

BlogProject is a .NET 8 application built using **Clean Architecture** principles. The project is designed to be maintainable, scalable, and testable, and it leverages modern design patterns and tools such as **CQRS**, **MediatR**, **AutoMapper**, **FluentValidation**, and the **Repository Pattern**. The application uses **SQL Server** as its database.

## 🚀 Features

- **Clean Architecture**  
  Ensures a well-organized, maintainable, and scalable codebase by separating concerns and enforcing clear boundaries between layers.

- **CQRS (Command Query Responsibility Segregation)**  
  Separates read and write operations to improve performance, scalability, and maintainability.

- **MediatR (Mediator Pattern)**  
  Decouples the request handling logic, making the code more modular and easier to test.

- **AutoMapper**  
  Simplifies object-to-object mapping between DTOs (Data Transfer Objects) and domain entities, reducing boilerplate code.

- **FluentValidation**  
  Provides a clean, fluent interface for validating user input and business logic.

- **Repository Pattern**  
  Abstracts data access logic, providing a clean API for interacting with the database and enabling easier testing and maintenance.

- **SQL Server**  
  Reliable and powerful database engine used to store and manage application data.

## 🗂️ Project Structure

/Core

/Infrastructure

/UI

## ⚙️ Technologies Used

- .NET 8
- MediatR
- AutoMapper
- FluentValidation
- SQL Server
- Entity Framework Core
- ASP.NET Core Web API

## 💡 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Setup

1. Clone the repository:

   ```bash
   git clone https://github.com/hvaezapp/BlogProject.git
