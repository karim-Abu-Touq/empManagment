# Employee Management System

A web-based Employee Management System built using ASP.NET Core MVC and SQL Server to organize and manage employee information.

## Overview

This project provides a centralized system for managing employees, departments, positions, and retired employees through a simple and organized dashboard.

## Features

- Employee Management (Create, Read, Update, Delete).
- Department Management.
- Position Management.
- Retired Employees Management.
- Dashboard with a modern interface.
- Dark Mode with saved theme preference.
- Organized database structure.

## Technologies Used

- C#
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- HTML5
- CSS3
- Bootstrap Icons
- JavaScript

## Architecture

The project follows the ASP.NET Core MVC architecture, separating application logic, data handling, and user interface components.

## Database

The application uses SQL Server for data storage and Entity Framework Core for database operations.

Main entities:
- Employees
- Departments
- Positions
- RetiredEmployees

## Getting Started

### Prerequisites

- Visual Studio 2022
- .NET SDK compatible with the project
- SQL Server

### Installation

1. Clone the repository:

   ```bash
   git clone YOUR_REPOSITORY_URL
   ```

2. Open the solution in Visual Studio 2022.

3. Configure your SQL Server connection string in `appsettings.json`.

4. Apply Entity Framework Core migrations if required:

   ```bash
   Update-Database
   ```

5. Run the application.

## Author

Developed as a personal learning project to practice ASP.NET Core MVC, Entity Framework Core, SQL Server, and web application development.
