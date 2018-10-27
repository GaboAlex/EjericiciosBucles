using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcular e imprimir la tabla de multiplicar de un número cualquiera. Imprimir el multiplicando, 
            //el multiplicador y el producto.
            //4 * 1 = 4
            //4 * 2 = 8
            Console.WriteLine("Tabla de Multiplicar");
            Console.WriteLine("Ingrese un numero");
            int n1 = int.Parse(Console.ReadLine());
            int mult = 0;
            for (int i = 0; i < 11; i++)
            {
                mult = n1 * i;
                Console.WriteLine(+n1+" * "+i+" = "+mult );
            }

        }
    }
}
