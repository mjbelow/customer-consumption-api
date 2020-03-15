This README file outlines the details of API created with .Net Core to work with database using EF Core.

## Prerequisites

# Needs to install:
* .Net Core SDK
* Git CLI
* Visual Code
* SQL Server

# Packages:
* JsonApiDotNetCore
* EF Core

## How to run Entity Framework Migrations:

*  Add Migration
`dotnet ef migrations add [CommitName]`

* Remove Migration
`dotnet ef migrations remove`

* Run Migration / Update Database
`dotnet ef database update`
