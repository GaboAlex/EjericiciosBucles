using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una persona debe realizar un muestreo con 20 personas para determinar el promedio de peso de los niños, 
            //jóvenes, adultos y viejos que existen en su zona habitacional. Se determinan las categorías con base en
            //la siguiente tabla: 
            //CATEGORIA EDAD
            //Niños 0 - 12
            //Jóvenes 13 - 29
            //Adultos 30 - 59
            //Anciano 60 en adelante
            Console.WriteLine("***Ingrese 20 Personas***\n");
            int[] edad = new int[20];
            int[] peso = new int[20];
            float pesoN = 0;
            float pesoJ = 0;
            float pesoA = 0;
            float pesoAn = 0;
            float promedioN = 0;
            float promedioJ = 0;
            float promedioA = 0;
            float promedioAn = 0;
            int cantN = 0;
            int cantJ = 0;
            int cantA = 0;
            int cantAn = 0;

            for (int i = 0; i < 20 ; i++)
            {
                Console.WriteLine("Ingrese Edad: ");
                edad[i]= int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese Peso: ");
                peso[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0;j<peso.Length;j++)
            {
                if (edad[j] > 0 && edad[j] <= 12) {
                    pesoN = pesoN + peso[j];
                    cantN++;
                } else if (edad[j] > 13 && edad[j] <= 29) {
                    pesoJ = pesoJ + peso[j];
                    cantJ++;
                } else if (edad[j] > 30 && edad[j] <= 59) {
                    pesoA = pesoA + peso[j];
                    cantA++;
                } else if (edad[j] > 60) {
                    pesoAn = pesoAn + peso[j];
                    cantAn++;
                }
            }
            promedioN = pesoN / cantN;
            promedioJ = pesoJ / cantJ;
            promedioA = pesoA / cantA;
            promedioAn = pesoAn / cantAn;
            Console.WriteLine("Hay "+cantN+" Niños y su promedio de peso es:"+promedioN);
            Console.WriteLine("Hay "+cantJ+" Jovenes y su promedio de peso es: "+promedioJ);
            Console.WriteLine("Hay "+cantA+" Adultos y su promedio de peso es: "+promedioA);
            Console.WriteLine("Hay "+cantAn+" Ancianos y su promedio de peso es: "+promedioAn);
        }
    }
}
