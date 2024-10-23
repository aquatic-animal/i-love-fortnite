using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    internal class Ejercicio4
    {
        static void Main()
        {
            int num1, num2, num3, num4;
            Console.WriteLine("Introduzca un año: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = num1 % 4; num3 = num1 % 100; num4 = num2 % 400;
            // num2 = dividir entre 4; num 3 = dividir entre 100; num4 = dividir entre 400
            if (num2 == 0 && num3 == 1 || num4 == 0) // si divido entre 4 y resto 0 = bisiesto | si divido entre 100 y resto 1 = bisiesto | O si divido entre 400 y resto 0 = bisiesto
            {
                Console.WriteLine("El año introducido ES bisiesto.");
            }
            else
            {
                Console.WriteLine("El año introducido NO es bisiesto.");
            }  
        }
    }
}
