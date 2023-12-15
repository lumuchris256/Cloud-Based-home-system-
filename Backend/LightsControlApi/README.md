# Lights Control API

The Lights Control API is a .NET Core backend application for controlling light bulbs. It provides a simple RESTful API for managing light bulbs in a home automation system.

## Table of Contents

- [Lights Control API](#lights-control-api)
  - [Table of Contents](#table-of-contents)
  - [Getting Started](#getting-started)
    - [Prerequisites](#prerequisites)
    - [Installation](#installation)
  - [5. Usage;](#5-usage)
  - [6. Database](#6-database)
  - [7. Contributing](#7-contributing)

## Getting Started

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) installed
- A code editor such as [Visual Studio Code](https://code.visualstudio.com/) or [Visual Studio](https://visualstudio.microsoft.com/)

### Installation

1. Clone the repository:

2. Navigate to the project directory:

```bash
   cd lights-control-api
```

3. Restore dependencies and build the project:

```bash
dotnet restore
dotnet build
```

4. Run the application:

```bash
dotnet run
```

5. Configuration:
   Make sure to configure the database connection string in the appsettings.json file. For example, when using Azure SQL Server:

```bash
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=tcp:your_server_name.database.windows.net,1433;Initial Catalog=your_database_name;Persist Security Info=False;User ID=your_username;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*"
}
```

## 5. Usage;

- End points:

* GET /api/lightbulb (Retrieve a list of all light bulbs.)
* POST /api/lightbulb(Add a new light bulb.)
* PUT /api/lightbulb/{id} (Update the state of a specific light bulb.)
* DELETE /api/lightbulb/{id} (Delete a specific light bulb.)

## 6. Database

The application uses Entity Framework Core to interact with the database. Database migrations can be applied using the following commands:

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

## 7. Contributing

Contributions are welcome! If you find any issues or have suggestions for improvements, feel free to open an issue or submit a pull request.
