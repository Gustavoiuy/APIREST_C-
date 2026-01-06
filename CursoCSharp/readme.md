# Curso CSharp desde cero

## Comandos para ejecutar 

```bash
# dentro de la raiz de la solución
dotnet run --project .\1Variables\1Variables.csproj

# dentro de la raiz del proyecto
dotnet run

# compilar 
dotnet build
```

## Comandos vistos en el curso para la creación de proyectos y soluciones

```bash
dotnet new sln -o CursoCSharp
 
dotnet new console -n 1Variables
dotnet sln .\CursoCsharp.sln add .\1Variables\1Variables.csproj


dotnet new console -n 2Condicionales
dotnet sln .\CursoCsharp.sln add .\2Condicionales\2Condicionales.csproj


dotnet new console -n 3Bucles
dotnet sln .\CursoCsharp.sln add .\3Bucles\3Bucles.csproj


dotnet new console -n 4Estructuras
dotnet sln .\CursoCsharp.sln add .\4Estructuras\4Estructuras.csproj


dotnet new console -n 5Metodos
dotnet sln .\CursoCsharp.sln add .\5Metodos\5Metodos.csproj

dotnet new console -n 6Clases
dotnet sln .\CursoCsharp.sln add .\6Clases\6Clases.csproj

dotnet new console -n 7Ficheros
dotnet sln .\CursoCsharp.sln add .\7Ficheros\7Ficheros.csproj

dotnet new console -n 8Exceptions
dotnet sln .\CursoCsharp.sln add .\8Exceptions\8Exceptions.csproj
```