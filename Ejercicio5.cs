using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    internal class Ejercicio5
    {
        static void Main()
        {
            int edad;
            Console.WriteLine("Introduzca su fecha de nacimiento.");
            edad = int.Parse(Console.ReadLine());
            if (edad >= 1960 && edad <= 2005)
            {
                Console.WriteLine("El usuario es mayor de edad.");
            }
            else if (edad >= 2006)
            {
                Console.WriteLine("El usuario es menor de edad.");
            }
            else if (edad <= 1959)
            {
                Console.WriteLine("El usuario está jubilado.");
            }
            else if (edad >= 2025)
            {
                Console.WriteLine("El usuario no existe.");
            }
            else if (edad < 1908)
            {
                Console.WriteLine("El usuario en cuestión está muerto."); // Curiosidad: La persona más vieja viva a dia de hoy nació en 1908 y tiene 116 años.
            }
        }
    }
}
