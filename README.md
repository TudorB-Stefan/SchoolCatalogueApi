# School Catalogue API

## Overview
The **School Catalogue API** is a simple CRUD (Create, Read, Update, Delete) application built using **.NET and ASP.NET Core Web API**. This project demonstrates a basic understanding of backend development, including RESTful API design, data persistence, and entity relationships.

## Features
- Manage **Classes**: Add, update, delete, and retrieve class information.
- Manage **Students**: Add, update, delete, and retrieve student records.

## Technologies Used
- **.NET**
- **ASP.NET Core Web API**
- **Entity Framework Core** (for database interactions)
- **SQL Server** (or any preferred database)

## Getting Started
### Prerequisites
- Install [.NET SDK](https://dotnet.microsoft.com/en-us/download)
- Install a database system (SQL Server, SQLite, PostgreSQL, etc.)
- Use an API testing tool like **Scalar**.

### Installation
1. Clone the repository:
   ```sh
   git clone https://github.com/your-username/school-catalogue-api.git
   cd school-catalogue-api
   ```
2. Restore dependencies:
   ```sh
   dotnet restore
   ```
3. Update the database:
   ```sh
   dotnet ef database update
   ```
4. Run the application:
   ```sh
   dotnet watch
   ```

## Configuration
Modify `appsettings.json` to configure the database connection string.

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=your_server;Database=SchoolCatalogue;User Id=your_user;Password=your_password;"
}
```

## Testing the API
Use **Swagger** to test API endpoints:
- Run the project and navigate to `http://localhost:<port>/swagger`.

Alternatively, use **Postman** to send API requests.

## Future Improvements
- Implement authentication and authorization
- Introduce pagination for large datasets
- Add unit tests and integration tests

## License
This project is open-source and available under the MIT License.

