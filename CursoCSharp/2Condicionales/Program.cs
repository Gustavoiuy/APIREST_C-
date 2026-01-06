
// condicionales y operadores

using System.Diagnostics.CodeAnalysis;

int edadPersona1 = 56;
int edadPersona2 = 75;



if (edadPersona1 > edadPersona2)
{
    Console.WriteLine("persona 1 es mayor que persona 2");
}
else
{
    Console.WriteLine("persona 1 es menor que persona 2");
}

edadPersona1 = 56;
edadPersona2 = 56;
if (edadPersona1 >= edadPersona2)
{
    Console.WriteLine("persona 1 es mayor o igual que persona 2");
}
if (edadPersona1 == edadPersona2)
{
    Console.WriteLine("persona 1 es igual que persona 2");
}
string sexoPersona1 = "hombre";

if ((edadPersona1 > edadPersona2) && (sexoPersona1 == "hombre"))
{
    Console.WriteLine("Persona 1 es mayor que persona 2 y además es hombre");
}

if (edadPersona1 > edadPersona2 || sexoPersona1 == "hombre")
{
    Console.WriteLine("Persona 1 es mayor que persona 2 y además es hombre");
}

int x = 10;
int y = 11;
int z = 3;

// Queremos que se cumpla:
// (x > 5 y (y < 10 o z == 3))

if (x > 5 && (y < 10 && z == 3))
{
    Console.WriteLine("Cumple condicion matematica");
}

string sexo = "hombre";
if (sexo != "mujer")
{
    Console.WriteLine("si es distinto de mujer");
}

bool usuarioAlta = false;

if (usuarioAlta)
{
    Console.WriteLine("si usuario alta");
}

bool usuarioPremium = false;

if (usuarioAlta && usuarioPremium)
{
    //
}

Console.WriteLine("*********switch************");

string nacionalidad = "dominicano";

if (nacionalidad == "uruguayo")
{
    Console.WriteLine("es uruguayo");
}
else if (nacionalidad == "argentino")
{
    Console.WriteLine("es argentino");
}
else if (nacionalidad == "español")
{
    Console.WriteLine("es español");
}
else
{
    Console.WriteLine("nacionalidad desconocida");
}


nacionalidad = "argentino";

switch (nacionalidad)
{
    case "uruguayo":
        Console.WriteLine("es uruguayo");
        break;
    case "argentino":
        Console.WriteLine("es argentino");
        Console.WriteLine("el presidente es milei");
        Console.WriteLine("es argentino!!!!!!!!!!!!!!!!!!!!!");
        Console.WriteLine("es argentino!!!!");
        break;
    case "español":
        Console.WriteLine("es español");
        break;
    default:
        Console.WriteLine("nacionalidad desconocida");
        break;
}


string cadenaLarga = "esto es una super cadena inventada a lo loco por juan camba";
cadenaLarga.Contains("gatito");

//ejercicio 1
// escribe un programa que ingrese por teclado la edad, el nombre y el sexo.
// si es mayor de 18 y es hombre, que muestre "Felicidades NOMBRE_AQUI eres un hombre y eres mayor de edad"
// si es mayor de 18 y es mujer, que muestre Felicidades NOMBRE_AQUI eres mujer y eres mayor de edad
// sino se cumple ninguna de la anteriores, que muestre el mensaje "eres menor"

//2) programa que busque en la cadena "esto es una cadena de prueba porque estoy empezando a programar en Csharp" las palbras prueba y programar
// si lo encuentra que emprima por pantalla "encontrado"
