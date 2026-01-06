Refactor de la aplicación CarRental1

Se extrae la lógica a un services.

Se crean tests unitarios y de integración

```
# generar proyecto
dotnet new xunit -o CarRental.Api.Tests
cd CarRental.Api.Tests
dotnet add reference ../CarRental.Api/CarRental.Api.csproj

# instalar paquetes
dotnet add package Moq
dotnet add package Microsoft.EntityFrameworkCore.InMemory

# comandos test
dotnet test
dotnet test --logger "console;verbosity=detailed"
dotnet test --filter "FullyQualifiedName~CarServiceTests"
dotnet test --filter "FullyQualifiedName~CarsControllerTests.DeleteCar_ReturnsNotFound_WhenCarDoesNotExist"
```

