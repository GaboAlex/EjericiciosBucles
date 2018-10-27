using System;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un Zoólogo pretende determinar el porcentaje de animales que hay en las siguientes tres categorías de edades: 
            //de 0 a 1 año, de más de 1 año y menos de 3 y de 3 o más años.El zoológico todavía no está seguro del animal que va a estudiar. 
            //Si se decide por elefantes solo tomara una muestra de 20 de ellos; si se decide por las jirafas, tomara 15 muestras, y si son chimpancés tomara 40.
            Console.WriteLine("1.- Elefante\n" +
                            "\n2.- Jirafas\n" +
                            "\n3.- Chimpances\n" +
                            "\nEliga uno de los 3 Animales:");
            int num = int.Parse(Console.ReadLine());
            int edad;
            float nino = 0;
            float joven = 0;
            float adulto = 0;
            float rs1;
            float rs2;
            float rs3;

            switch (num)
            {
                case 1:
                    Console.WriteLine("Elefantes");
                    for (int i = 1; i <= 20; i++)
                    {
                        Console.WriteLine("Edad del Animal N" + i + ":");
                        edad = int.Parse(Console.ReadLine());
                        if (edad == 0 || edad == 1)
                        {
                            nino++;
                        }
                        else if (edad > 1 && edad < 3)
                        {
                            joven++;
                        }
                        else if (edad >= 3)
                        {
                            adulto++;
                        }
                    }
                    rs1 = (nino / 20) * 100;
                    rs2 = (joven / 20) * 100;
                    rs3 = (adulto / 20) * 100;
                    Console.WriteLine("Procentajes de Animales entre 0-1: " + rs1);
                    Console.WriteLine("Procentajes de Animales entre 1-3: " + rs2);
                    Console.WriteLine("Procentajes de Animales entre 3-a mas: " + rs3);
                    break;
                case 2:
                    Console.WriteLine("Jirafas");
                    for (int i = 1; i <= 15; i++)
                    {
                        Console.WriteLine("Edad del Animal N" + i + ":");
                        edad = int.Parse(Console.ReadLine());
                        if (edad == 0 || edad == 1)
                        {
                            nino++;
                        }
                        else if (edad > 1 && edad < 3)
                        {
                            joven++;
                        }
                        else if (edad >= 3)
                        {
                            adulto++;
                        }
                    }
                    rs1 = (nino / 15) * 100;
                    rs2 = (joven / 15) * 100;
                    rs3 = (adulto / 15) * 100;
                    Console.WriteLine("Procentajes de Animales entre 0-1: " + rs1);
                    Console.WriteLine("Procentajes de Animales entre 1-3: " + rs2);
                    Console.WriteLine("Procentajes de Animales entre 3-a mas: " + rs3);
                    break;
                case 3:
                    Console.WriteLine("Chimpances");
                    for (int i = 1; i <= 40; i++)
                    {
                        Console.WriteLine("Edad del Animal N" + i + ":");
                        edad = int.Parse(Console.ReadLine());
                        if (edad == 0 || edad == 1)
                        {
                            nino++;
                        }
                        else if (edad > 1 && edad < 3)
                        {
                            joven++;
                        }
                        else if (edad >= 3)
                        {
                            adulto++;
                        }
                    }
                    rs1 = (nino / 40) * 100;
                    rs2 = (joven / 40) * 100;
                    rs3 = (adulto / 40) * 100;
                    Console.WriteLine("Procentajes de Animales entre 0-1: " + rs1);
                    Console.WriteLine("Procentajes de Animales entre 1-3: " + rs2);
                    Console.WriteLine("Procentajes de Animales entre 3-a mas: " + rs3);
                    break;
                default:
                    Console.WriteLine("Numero ingresado incorrecto");
                    break;
            }
        }
    }
}
