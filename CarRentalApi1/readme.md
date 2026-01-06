# Restricciones de la aplicación

Agregar un crud para coches

Si un coche está siendo alquilado no podrá ser alquilado por otra persona

Los coches no podrán darse de alta ti tiene una antigüedad mayor que 5 años.


Comandos vistos en el video:
```bash
#creación del proyecto
dotnet new sln -o CarRentalApi1

cd CarRentalApi1
dotnet new webapi --use-controllers -n CarRental.Api
 
dotnet sln  add .\CarRental.Api\

# paquetes
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design

# Migraciones de base de datos
dotnet ef migrations add InitialCreate
# creamos la base de datos si no existe 
dotnet ef database update

dotnet ef migrations add AddPriceToRental
dotnet ef database update



```



# Mejorar:


Validar que exista el usuario cuando se crea un alquiler

Agregar un crud para usuarios

Agregar endpoint a RentalsController para obtener informes de los alquileres

