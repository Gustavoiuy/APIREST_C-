// variables

Console.WriteLine("Hello, World!");



string miCadena = "hola, esto es una cadena";
Console.WriteLine(miCadena);

miCadena = string.Empty;
Console.WriteLine(miCadena);
/*
Console.WriteLine("Meta su nombre por consola..");
//string tuNombre = Console.ReadLine()!;

Console.WriteLine("Escribe tu edad");
string entradaEdad = Console.ReadLine()!;
//int edad = Convert.ToInt32(entradaEdad);
*/



//Console.WriteLine("Tu nombre es " + tuNombre + " y tienes " + edad + "Años");


string nombre = "juan";
string apellido = "camba";

Console.WriteLine(nombre + apellido);
Console.WriteLine($"Nombre: {nombre}, apellido: {apellido}");

Console.WriteLine("Nombre {0}, apellido {1}", nombre, apellido);

Console.WriteLine("**************Numeros**************");

int numero1 = 23;
int numero2 = 10;

int resultado = numero1 + numero2;

Console.WriteLine(resultado);

Console.WriteLine("resultado: " + Convert.ToInt32(numero1 + numero2));

Console.WriteLine(numero1 - numero2);
Console.WriteLine(numero1 / numero2);
Console.WriteLine(numero1 * numero2);


string num1 = "10";
string num2 = "10";

int resultadoparseo = Convert.ToInt32(num1);

Console.WriteLine(Convert.ToInt32(num1) + Convert.ToInt32(num2));



float f = 1f / 3f;       // 0.3333333 (aproximado)
double d = 1.0 / 3.0;    // 0.3333333333333333 (más preciso)
decimal m = 1m / 3m;     // 0.3333333333333333333333333333 (muy preciso)

Console.WriteLine($"float: {f}");
Console.WriteLine($"double: {d}");
Console.WriteLine($"decimal: {m}");

decimal salario = 1205.25M;
decimal aumentoSalarial = 10.10m;


Console.WriteLine("Aumento (mal hecho)" + salario + aumentoSalarial);

float resultadoFinal = (float)(salario + aumentoSalarial);

Console.WriteLine("Aumento (ok)" + resultadoFinal);

Console.WriteLine("******** bools and var*****************");

bool esMayorDeEdad = false;
Console.WriteLine(esMayorDeEdad);
esMayorDeEdad = true;
Console.WriteLine(esMayorDeEdad);

var variableCualquiera = "Una cadena";


var edad = 23;

var floatVar = 1f;

var esHombre = false;

/*
Ejercicios: 
escribe un progrma que pida dos numeros por pantalla, los sume y muestre el resultado (tienes que convertir el string en int)

igual que el anterior pero que sean tres numeros.

*/