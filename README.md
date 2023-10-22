# Inventory Management System

This is a simple Inventory Management System built using Blazor Server and following the Clean Architecture principles in .NET 6. This application allows you to perform basic CRUD (Create, Read, Update, Delete) operations on inventory items. It's designed to serve as a foundational example of how to structure and build a .NET application with Blazor Server.

## Features

- Create, Read, Update, and Delete inventory items.
- A clean and modular codebase following Clean Architecture principles.
- Blazor Server for the web-based front-end.
- .NET 6 for server-side code.
- Entity Framework Core for database operations.
- Responsive design for various screen sizes.

## Prerequisites

Before running this application, ensure that you have the following prerequisites installed:

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- Visual Studio 2022 or Visual Studio Code (with C# extension) for development.
- SQL Server or another compatible database server for storing data.

## Getting Started

1. Clone this repository to your local machine:

   ```bash
   git clone https://github.com/Kaylin98/inventory-management-system.git
   ```

2. Open the solution in Visual Studio 2022 or your preferred IDE.

3. Configure the database connection in the `appsettings.json` file. You can use SQL Server or another database provider.

4. Open the Package Manager Console or a terminal window and run the following commands to create and migrate the database:

   ```bash
   dotnet ef database update -c ApplicationDbContext -p src/Infrastructure/Infrastructure.csproj -s src/Web/Web.csproj
   ```

5. Build and run the application:

   - If you're using Visual Studio, simply press F5 to build and run the project.
   - If you're using Visual Studio Code or the terminal, navigate to the project directory and run:

     ```bash
     dotnet run --project src/Web/Web.csproj
     ```

6. Access the application in your web browser at `https://localhost:5001` (or another URL, as configured).

## Usage

- Perform CRUD operations by adding, updating, or deleting items.


## Contributing

Contributions to this project are welcome. Feel free to open issues or submit pull requests to improve the functionality, add new features, or fix bugs.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact

If you have any questions or need assistance, you can reach out to the project owner at [your.email@example.com](mailto:your.email@example.com).

Thank you for using the Inventory Management System!

**Happy coding!**
