## User Management App

A simple ASP.net MVC app, that Creates, Update and delete users, the app also lists all users

### Technology used 

- Dotnet 6
- Asp.net MVC
- Entity Framework core 

### How to Run the app 

on a machine with Dotnet 6 installed, please do the following. 

- Clone this repo to your machine 
- Change the connection string to point to a sql server database in file `UserMangment/appsettings.json` , orleave it as is to create a local db. 
- in the root folder of the repo/ VS terminal run this command `Update-Database` to create the database using `EF Core`
- From VS run the project 

### Reference 

https://docs.microsoft.com/en-us/aspnet/core/tutorials/choose-web-ui?view=aspnetcore-6.0
Choose an ASP.NET Core UI
Learn when to use which ASP.NET Core web UI technologies. Understand the server, client and hybrid options.

