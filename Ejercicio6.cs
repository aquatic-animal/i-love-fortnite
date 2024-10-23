using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    internal class Ejercicio6
    {
        static void Main()
        {
            string resp1, resp2, respcor1, respcor2;
            int resp3, respcor3;
            respcor1 = ("roma");
            Console.WriteLine("Responde a las siguientes cuestiones correctamente");
            Console.WriteLine("¿Cuál es la capital de Italia?");
            resp1 = Console.ReadLine().ToLower();
            if (resp1 == respcor1)
            {
                Console.Beep(2000, 1000);
                Console.WriteLine("Respuesta correcta.");
            }
            else
            {
                 Console.Beep(500, 1000);
                 Console.WriteLine("Respuesta incorrecta.");
            }
            respcor2 = ("hurricane");
            Console.WriteLine("¿Cómo se traduce al inglés la palabra Huracán?");
            resp2 = Console.ReadLine().ToLower();
            if (resp2 == respcor2)
            {
                Console.Beep(2000, 1000);
                Console.WriteLine("Respuesta correcta.");
            }
            else
            {
                Console.Beep(500, 1000);
                Console.WriteLine("Respuesta incorrecta.");
            }
            respcor3 = 12;
            Console.WriteLine("¿Cuál es la raíz cuadrada del número 144? Responda con un número.");
            resp3 = int.Parse(Console.ReadLine());
            if (resp3 == respcor3)
            {
                Console.Beep(2000, 1000);
                Console.WriteLine("Respuesta correcta.");
            }
            else
            {
                Console.Beep(500, 1000);
                Console.WriteLine("Respuesta incorrecta.");
            }
        }
    }
}
