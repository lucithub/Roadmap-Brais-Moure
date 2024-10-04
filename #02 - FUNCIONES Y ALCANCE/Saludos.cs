using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___FUNCIONES_Y_ALCANCE
{
    public class Saludos
    {
        public static void Saludo()
        {

        }
        public string Saludo2(string nombre)
        {
            return "Hola " + nombre;
        }
        public string Saludo3(string nombre, string apellido)
        {
            return "Hola " + nombre + "" + apellido;
        }
        public string Saludo4(string nombre, string apellido, string mensaje)
        {
            return mensaje + "" + nombre + " " + apellido;
        }
        //Comprueba si puedes crear funciones dentro de funciones.
        public void Saludo5()
        {
            void Saludo6()
            {
                Console.WriteLine("Hola 6");
            }
            Saludo6();
            Saludo2("Lucas");
        }
        //Utiliza algún ejemplo de funciones ya creadas en el lenguaje.

        //Pon a prueba el concepto de variable LOCAL y GLOBAL.
        public string VariableLocal { get; set; }
        public string Saludo7(string nombre)
        {
            VariableLocal = "Hola " + nombre;
            return VariableLocal;
        }

        public string Saludo8()
        {
            VariableLocales v1 = new VariableLocales();
            v1.VariableGlobal = "Hola Mundo";
            return v1.VariableGlobal;
        }
    }
}
