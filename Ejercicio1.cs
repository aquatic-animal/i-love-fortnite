namespace Condicionales
{
    internal class Ejercicio1
    {
        static void Main(string[] args)
        {
            float num1, comprobacion;
            Console.WriteLine("Introduzca un valor: ");
            num1 = float.Parse(Console.ReadLine());
            comprobacion = num1 % 2;
            if (comprobacion == 0)
            {
                Console.WriteLine("¡¡El número introducido es par!!");
            }
            else 
            {
                Console.WriteLine("¡¡El número introducido es impar!!");
            }
        }
    }
}
