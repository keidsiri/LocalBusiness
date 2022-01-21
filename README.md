# Local Business API

#### API for a local business lookup. The API will list restaurants and local shops. in C#

#### Created By: Kate Kiatsiri

## Technologies Used

* C#
* CSS
* .NET 5
* NuGet
* ASP.NET Core
* Entity Framework Core
* MySql & MySql Workbench
* PostMan
* Swagger

## Description

This is an API for Local businesses such as restaurants and local shops in Seattle greater area. The API has full CRUD functionality such as GET, GET(id), POST and DELETE also has extra UI functionality with Swagger so user can easily modify without using Postman.

This is 13th independent project at Epicodus to demonstrate understanding of building an API.

## Setup and Installation Requirements

### Requirements

* Download and install [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
* Download and install a code text editor. Ex: [VS Code](https://code.visualstudio.com/)
* Download, install, and complete setup for [MySql Community Server](https://dev.mysql.com/downloads/file/?id=484914) and [MySql Workbench](https://dev.mysql.com/downloads/file/?id=484391).

### Installation and Setup

* Clone [this](https://github.com/keidsiri/LocalBusiness) repository to your local machine
* navigate to the project directory `LocalBusiness.Solution/LocalBusiness`
* To install required packages, navigate to LocalBusiness.Solutions/LocalBusiness in the terminal and type the following commands:
  `dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0`
  `dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2`
  `dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0`


* Create a file named "appsettings.json" in the LocalBusiness directory
  - add the following code to the appsettings.json file:
  ```
  {
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=local_business;uid=root;pwd=[YOUR-PASSWORD-HERE];"
    }
  }
  ```
  - replace [YOUR-PASSWORD-HERE] with your unique MySql password

* To Import the required database:
   - In the terminal, navigate to LocalBusiness.Solution/LocalBusiness and run the command:
    ` dotnet ef database update `

* To Make Changes to the Database:
  - If you would like to change the database, make changes in the proper models files, then run the following commands in the terminal navigated to LocalBusiness.Solution/LocalBusiness: <br>
    ` dotnet ef migrations add YourDescriptionHere` <br>
    ` dotnet ef database update`

* To Restore, build, and run the project in LocalBusiness folder
  - Run the command `$ dotnet restore` to restore the project dependencies
  - Run the command `$ dotnet build` to build and compile the project
  - Run the command `$ dotnet run` to build and compile the project

* To see, update , add or delete to the API go to [Postman](https://www.postman.com/) with the address "http://localhost:5000/api/Businesses

## Known Bugs

* none 

### License

[MIT License](https://opensource.org/licenses/MIT)
Copyright 2021 Kate Kiatsiri

## Contact Information

[Email : Kate Kiatsiri ](mailto:keidsiri@gmail.com)

[![GitHub Badge](https://img.shields.io/badge/GitHub-100000?style=for-the-badge&logo=github&logoColor=white)](https://github.com/keidsiri)
[![LinkedIn Badge](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/kiatsiri)