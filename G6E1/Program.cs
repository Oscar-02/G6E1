using System;

namespace G6E1
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplicador = 0, tabla;
            bool error = true;
            while (error == true)
            {
                try
                {
                    Console.WriteLine("Ingrese el numero a mostrar...");
                    multiplicador = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");
                    error = false;
                }
                catch
                {
                    error = true;
                    Console.WriteLine("ERROR. Has ingresado un valor no valido, intentelo de nuevo...");
                    Console.WriteLine("Presione cualquier tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            Console.WriteLine("TABLA DE MULTIPLICAR DE " + multiplicador);
            for (int i = 0; i < 13; i++)
            {
                tabla = multiplicador * i;
                Console.WriteLine( multiplicador + "x" + i + "=" + tabla);
            }
            Console.WriteLine("\nPresione cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
