using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    internal class Ejercicio7
    {
        static void Main()
        {
            DateTime actual = DateTime.Now;
            bool happyHour = actual.Hour % 2 == 0; // Para determinar si es o no es happy hour
            int mojito, bloodymary, pinnacolada;
            double preciototal;
            preciototal = 0;
            mojito = 8; bloodymary = 10; pinnacolada = 10;
            string respuesta;
            Console.WriteLine("Bienvenido al bar. Desea un Mojito, un Bloody Mary, o una Piña Colada?");
            respuesta = Console.ReadLine().ToLower(); // El .ToLower es para evitar el "case-sensitive" del input. De esta forma el case siempre será en minúscula.
            switch (respuesta)
            {
                case "mojito":
                    Console.WriteLine("Mojito pedido. 8 euros");
                    preciototal += preciototal + mojito;
                    break;
                case "bloody mary":
                    Console.WriteLine("Bloody Mary pedido. 10 euros");
                    preciototal += preciototal + bloodymary;
                    break;
                case "piña colada":
                    Console.WriteLine("Piña Colada pedida. 10 euros");
                    preciototal += preciototal + pinnacolada;
                    break;
            }
            if (happyHour == true)
            {
                preciototal = preciototal *= 0.8; // aplicar 20% descuento al precio total
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("TIENES DESCUENTO PORQUE LA HORA ES PAR");
            }
            else
            {
                Console.WriteLine("No tienes descuento, porque la hora es impar.");
            }
            Console.WriteLine("El total de tu cuenta es: " + preciototal + " euros.");
        }
    }
}
