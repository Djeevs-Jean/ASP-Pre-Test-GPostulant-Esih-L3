run:
	dotnet watch

build:
	dotnet build

list_package:
	dotnet list package

# dotnet remove package <PACKAGE_NAME>

install1:
	dotnet add package Microsoft.EntityFrameworkCore

install2:
	dotnet add package Microsoft.EntityFrameworkCore.Design

install3:
	dotnet add package Microsoft.EntityFrameworkCore.Sqlite

install4:
	dotnet add package Microsoft.EntityFrameworkCore.tools

# ef database
migrations:
	dotnet ef migrations add InitialCreate

migration_update:
	dotnet ef database update

# add page
# dotnet new page --name Index --output Pages/Postulants