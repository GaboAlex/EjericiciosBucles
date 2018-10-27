using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Suponga que se tiene un conjunto de calificaciones de un grupo de 10 alumnos.
            //Realizar un algoritmo para calcular la calificación media y la calificación más baja de todo el grupo.
            int[] conteo = new int[10];
            int media = 0;
            int media1 = 0;      
            int suma = 0;
            for (int i = 0;i<conteo.Length;i++) {
                Console.WriteLine("Ingrese las notas");
                conteo[i] = int.Parse(Console.ReadLine());
            }
            int baja = conteo[0];
            Console.WriteLine("\n");
            for (int i = 0; i < conteo.Length; i++) {
                Console.WriteLine(conteo[i]);
            }
            Console.WriteLine("\n");
            for (var j = 1;j<conteo.Length;j++)
            {
                if (baja > conteo[j])
                {
                    baja = conteo[j];
                }
            }
            for (var i = 0;i<conteo.Length;i++)
            {
                suma = suma + conteo[i];
            }
            media1 = suma / 10;
            //Array.Sort(conteo); Ordenar el arreglo
            media = conteo[conteo.Length / 2-1];
            Console.WriteLine("La calificacion mas baja es: " + baja);
            Console.WriteLine("La posicion media es: " + media);
            Console.WriteLine("La media de las notas es: " + media1);
        }
    }
}
