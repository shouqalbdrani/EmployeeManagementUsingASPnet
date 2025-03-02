# EmployeeManagementUsingASPnet

ASP.net program that use MVC to perform CRUD ( create , read , update , delete ) operations to employees

The user can Add , Edit , Delete and List Employees useing Entity Framework with My sql 

Set Up process :
open the appsettings.json and update "ConnectionStrings": {
  "DefaultConnection": "server=localhost;database=EmployeeDb;user=root;password=12345678;"

  Apply Migrations & Create the Database
  using the cmd 
  dotnet ef migrations add InitialCreate
  dotnet ef database update


  
