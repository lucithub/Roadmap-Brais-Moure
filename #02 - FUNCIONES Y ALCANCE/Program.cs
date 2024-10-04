//Crea ejemplos de funciones básicas que representen las diferentes
//    posibilidades del lenguaje:
//Sin parámetros ni retorno, con uno o varios parámetros, con retorno...
using _02___FUNCIONES_Y_ALCANCE;
using System;
using System.Runtime.Intrinsics;
public class Program
{
    public static void Main()
    {
        //Ejemplo de función sin parámetros ni retorno
        Saludos.Saludo();
        //Ejemplo de función con un parámetro y retorno
        Saludos s1 = new Saludos();
        Console.WriteLine(s1.Saludo2("Lucas"));
        //Ejemplo de función con dos parámetros y retorno
        Console.WriteLine(s1.Saludo3("Lucas", "Gonzalez"));
        //Ejemplo de función con tres parámetros y retorno
        Console.WriteLine(s1.Saludo4("Lucas", "Gonzalez", "Hola"));
        //Ejemplo de función con función dentro de otra función
        s1.Saludo5();
        //Ejemplo de función con variable local
        Console.WriteLine(s1.Saludo7("Lucas"));
        //Ejemplo de función con variable global
        Console.WriteLine(s1.Saludo8());
        //Dificultad extra en la otra clase y despues la llamo
        VariableLocales v2 = new VariableLocales();
        string queDevuelve = v2.Dificultad("Hola", "Mundo");
        Console.WriteLine(queDevuelve);
    }
}
