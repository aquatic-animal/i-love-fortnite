using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    internal class Ejercicio3
    {
        static void Main()
        {
            int num1;
            Console.WriteLine("Introduzca un valor del uno al siete.");
            num1 = int.Parse(Console.ReadLine());
            if (num1 > 7)
            {
                Console.WriteLine("El número introducido no es válido.");
            }
            else if (num1 < 1)
            {
                Console.WriteLine("El número introducido no es válido.");
            }
            else if (num1 == 1)
            {
                Console.WriteLine("El día de la semana correspondiente es el Lunes.");
            }
            else if (num1 == 2)
            {
                Console.WriteLine("El día de la semana correspondiente es el Martes.");
            }
            else if (num1 == 3)
            {
                Console.WriteLine("El día de la semana correspondiente es el Miércoles.");
            }
            else if (num1 == 4)
            {
                Console.WriteLine("El día de la semana correspondiente es el Jueves.");
            }
            else if (num1 == 5)
            {
                Console.WriteLine("El día de la semana correspondiente es el Viernes.");
            }
            else if (num1 == 6)
            {
                Console.WriteLine("El día de la semana correspondiente es el Sábado.");
            }
            else if (num1 == 7)
            {
                Console.WriteLine("El día de la semana correspondiente es el Domingo.");
            }
        }
    }
}
