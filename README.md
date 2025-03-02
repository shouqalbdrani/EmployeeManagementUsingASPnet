# EmployeeManagementUsingASPnet

ASP.net program that use MVC to perform CRUD ( create , read , update , delete ) operations to employees

The user can Add , Edit , Delete and List Employees useing Entity Framework with My sql 

Set Up process :
instal Pomelo.EntityFrameworkCore.MySql using this cmd
dotnet add package Pomelo.EntityFrameworkCore.MySql
dotnet add package Microsoft.EntityFrameworkCore.Tools

open the appsettings.json and update "ConnectionStrings": {
  "DefaultConnection": "server=localhost;database=EmployeeDb;user=root;password=12345678;"

  Apply Migrations & Create the Database
  using the cmd 
  dotnet ef migrations add InitialCreate
  dotnet ef database update
  


  ![Screenshot 2025-03-02 191724](https://github.com/user-attachments/assets/bd46da1a-a80f-488b-91ce-2a65fe3bac92)
![Screenshot 2025-03-02 191820](https://github.com/user-attachments/assets/c8083801-7e0d-47c2-ae58-e96b161a3a34)

![Screenshot 2025-03-02 191752](https://github.com/user-attachments/assets/911a424a-c535-404c-8d3b-2fce0e988a3c)
![Screenshot 2025-03-02 191810](https://github.com/user-attachments/assets/1e7bdd14-520a-42c4-87e3-caa76c0f655b)
