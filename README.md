To launch the web page do the following:

#Install from Nuget 

Microsoft.EntityFrameworkCore

Microsoft.EntityFrameworkCore.Tools

Microsoft.EntityFrameworkCore.SqlServer



#Remove Migration file

#In appsetting.json file change the server with your local server

#In package manager console:

add-Migration InitialCreate

update-database

