//Crea ejemplos utilizando todos los tipos de operadores de tu lenguaje:
//*Aritméticos, lógicos, de comparación, asignación, identidad, pertenencia, bits...

//Operadores ARITMETICOS
//Operadores unarios: ++, --, +, -
//Operadores binarios: *, /, %, +, -

//Operadores de COMPARACION
//==, !=, >, <, >=, <=

//Operadores logicos BOOLEANOS
//&&, ||, !, |, &, ^

//Operadores de DESPLAZAMIENTO y BIT A BIT 
//<<, >>, &, |, ^, ~, >>>

//Operadores de IGUALDAD
//==, !=

//Operadores de ASIGNACION
//=, +=, -=, *=, /=, %=, &=, |=, ^=, <<=, >>=

//Operadores de IDENTIDAD
//is, as

//Operadores de PERTENENCIA
//in

//Operadores de CONDICIONALES
//?:

//Operadores de NULL
//??, ?.

//Operadores de TIPO
//typeof, sizeof, default

//Operadores de UNIDAD
//checked, unchecked

//Utilizando las operaciones con operadores que tú quieras, crea ejemplos
//que representen todos los tipos de estructuras de control que existan
//en tu lenguaje:
//Condicionales, iterativas, excepciones...
//Debes hacer print por consola del resultado de todos los ejemplos.

var option = 2;

if (option == 1)
{
    Console.WriteLine(1);
}

switch (option)
{
    case 1:
        Console.WriteLine(1);
        break;
    case 2:
        Console.WriteLine(2);
        break;
}

while (option < 3)
{
    Console.WriteLine(option);
    option++;
}

do
{
    Console.WriteLine("opcion es menor a 3");
} while (option < 3);

for (int i = 0; i < 3; i++)
{
    Console.WriteLine(i);
}

foreach (var i in new int[] { 1, 2, 3 })
{
    Console.WriteLine(i);
}

try
{
    throw new Exception("Error");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

//DIFICULTAD EXTRA(opcional):
//Crea un programa que imprima por consola todos los números comprendidos
//entre 10 y 55 (incluidos), pares, y que no son ni el 16 ni múltiplos de 3.

for (int i = 10; i < 56; i++)
{
    if (i % 2 == 0 && i != 16 && i % 3 != 0)
    {
        Console.WriteLine(i);
    }
}