# calculate_net_gross_vat_for_purchases
As a web portal user, I would like to calculate Net, Gross, VAT amounts for purchases in Portugal, United Kingdom, Spain and France so that I can use correctly calculated data.

## Open Packet Manager Console to install Entity Framework:

dotnet ef -> To verify that EF Core CLI tools are correctly installed

dotnet tool install --global dotnet-ef -> To install

## After install the following NuGet Packets:

Microsoft.EntityFrameworkCore (7.0.0)

Microsoft.EntityFrameworkCore.Design (7.0.0)

Microsoft.EntityFrameworkCore.SqlServer (7.0.0)

## Finally run the following commands to start working with Entity Framework:

dotnet ef migrations add InitialCreate -> To create de database

dotnet ef migrations remove -> To remove last migration

dotnet ef database update 0 -> To unapply all migration

dotnet ef database update -> Updates the database to the last migration

NOTE: The database was configured in Microsoft SQL Server Management Studio with SQL Express 

## Angular Commands

ng new [project-name] -> To install Angular

ng g s [service-name] --skip-tests -> To create a service

ng serve -o -> To start the front end project
