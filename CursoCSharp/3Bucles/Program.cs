// bucles
int contador = 0;

Console.WriteLine(contador);

contador = contador + 1;
contador = contador + 1;

Console.WriteLine(contador);

contador++;
Console.WriteLine(contador);

for (int i = 0; i < 5; i++)
{
    int valorDeI = i;
    Console.WriteLine($"Valor i {valorDeI}");
}

int j = 0;
while (j < 5)
{
    Console.WriteLine($"j vale {j}");
    j++;
}

int k = 0;
do
{
    Console.WriteLine($"el valor de k es {k}");
    k++;
} while (k < 5);


//desafio bucle for hasta 10 yque indique si el numero (el incremento) en custion es par o no
//para saber si es par el numero usa el operador %2, es decir  numero % 2 == 0 esto retorna un true si es para, false si no lo es