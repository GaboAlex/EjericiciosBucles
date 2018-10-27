using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simular el comportamiento de un reloj digital, 
            //imprimiendo la hora, minutos y segundos de un día desde las 0:00:00 horas hasta las 23:59:59 horas.

            Console.WriteLine("Simulacion de comportamiento de Reloj Digital:");

            for (int h = 00; h <= 23; h++)
            {
                for (int m = 00; m <= 59; m++)
                {
                    for (int s = 00; s <= 59; s++)
                    {
                        Console.WriteLine(h + ":" + m + ":" + s);
                    }
                }
            }
            Console.WriteLine("Simulacion finalizada.");
            Console.ReadKey();
        }
    }
}
