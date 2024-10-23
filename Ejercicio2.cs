using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    internal class Ejercicio2
    {
        static void Main()
        {
            int num1, num2, num3;
            Console.WriteLine("Introduzca el primer valor: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo valor: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el tercer valor: ");
            num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num2 > num3)
            {
                Console.WriteLine("El valor más grande de los tres números introducidos es: " + num1);
            }
            else if (num2 > num3 && num2 > num3)
            {
                Console.WriteLine("El valor más grande de los tres números introducidos es " + num2);
            }
            else if (num3 > num2 && num3 > num2)
            {
                Console.WriteLine("El valor más grande de los tres números introducidos es " + num3);
            }
        }
    }
}
