# UIowaClaims
This is a clean architecture based .NET Core 8 api and Angular 18 hybrid webapp. 

## 🔧 Technologies Used

- **ASP.NET Core 8.0**
- **Entity Framework Core** (SQLite)
- **Angular** (v18)
- **nodejs -npm -v18** (v18)
- **Swagger** (OpenAPI documentation)
- **Clean Architecture pattern**

---

## 📁 Folder Structure

```
src/
├── UIowaClaims.Core/         # Domain entities and interfaces (pure domain logic)
│   ├── Entities/             # Core business entities
│   └── Interfaces/           # Contracts for repositories/services (no implementations)
│
├── UIowaClaims.Application/  # Use cases and business logic
│   ├── DTOs/                 # Data Transfer Objects
│   ├── Interfaces/           # Application-level contracts (e.g., services, use cases)
│   └── Services/             # Application services implementing use cases
│
├── UIowaClaims.Infrastructure/  # External dependencies: database, file system, APIs
│   ├── Persistence/          # EF Core DbContext and configurations
│   ├── Repositories/         # Concrete repository implementations
│   └── Services/             # Infrastructure-level services (e.g., file storage)
│
├── UIowaClaims.API/          # ASP.NET Core Web API
│   ├── Controllers/          # HTTP endpoints
│   ├── DB/                   # SQL Lite DB Location
│   ├── Resources/            # Uploaded files location (this should be an FTP in full-fledged application.)
│   ├── ViewModels/           # ViewModels for API
│   └── Program.cs            # Application startup and dependency injection
|
├── UIowaClaims.Web/          # ASP.NET Core MVC + Angular Hybrid web app
│   ├── Controllers/          # MVC endpoints
│   ├── wwwroot/              # Location of the public files ie; html, css, angular build files, images etc
│   ├── ClientApp             # Angular 18 source code
│   ├── Models/               # MVC specific models
│   ├── Views/                # Razor views
│   └── Program.cs            # Application startup and dependency injection

```
## 🚀 Getting Started

1. Clone the repo.
2. Start the API and Web projects.

- Landing page screenshot
  ![image](https://github.com/user-attachments/assets/86fcb9b9-fba4-4d4c-ae1a-f96be1bd5eb7)

- Reimbursement Form screenshot
  ![image](https://github.com/user-attachments/assets/a5ae87a2-a035-44ff-91d5-a0ba0e52bed7)
  
- View list of Reimbursement filings
  ![image](https://github.com/user-attachments/assets/2fe49d07-a8e1-4360-b07d-df614bed6fbf)

-swagger ui (for api) screenshot 
![image](https://github.com/user-attachments/assets/b670d1fa-8623-4f12-8ec8-d1210b83a6c9)














