using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___FUNCIONES_Y_ALCANCE
{
    public class VariableLocales
    {
        public string VariableGlobal { get; set; }
        public string Dificultad(string cadena1, string cadena2)
        {
            int i2 = 0;
            for (int i = 1; i < 101; i++)
            {
                
                
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(cadena1+" "+cadena2);
                    i2++;
                }
                else
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine(cadena1);
                        i2++;
                    }
                    if (i % 5 == 0)
                    {
                        Console.WriteLine(cadena2);
                        i2++;
                    }
                    else
                    {
                        Console.WriteLine(i);
                        i2++;
                    }
                }
            }
            string cant = "Cantidad: " + i2;
            return cant;
        }
    }
}
