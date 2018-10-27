using System;

namespace BLUCLE_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio1();
            //Ejercicio2();
            //StringBuilderTest.Ejercicio3();
            //Ejercicio4();
            StringBuilderTest.Ejercicio5();
        }
        //Calcular el promedio de un alumno que tiene 7 calificaciones en la materia de 
        //Algoritmos Avanzados y estructura de Datos.
        public static void Ejercicio1()
        {
            Console.WriteLine("**Escoja el Curso para ingresar Notas**\n" +
                "1.- Algoritmos Avanzados\n" +
                "2.- Estructura de Datos\n");
            int curso = int.Parse(Console.ReadLine());
            int suma = 0;
            int promedio = 0;
            switch (curso)
            {
                case 1:
                    for (int i = 0; i < 8; i++)
                    {
                        Console.WriteLine("Ingrese la nota de Algoritmos Avanzados:");
                        int nota = int.Parse(Console.ReadLine());
                        suma = suma + nota;
                    }
                    promedio = suma / 7;
                    Console.WriteLine("El promedio de la notas ingresadas es: "+ promedio);
                    break;
                case 2:
                    for (int i = 0; i < 8; i++)
                    {
                        Console.WriteLine("Ingrese la nota de Estructura de Datos:");
                        int nota = int.Parse(Console.ReadLine());
                        suma = suma + nota;
                    }
                    promedio = suma / 7;
                    Console.WriteLine("El promedio de la notas ingresadas es: " + promedio);
                    break;
                default:
                    Console.WriteLine("Numero ingresado INCORRECTO");
                    break;
            }
        }
        //Leer 10 números y obtener su cubo y su cuarta.
        public static void Ejercicio2() {
            int num = 0;
            int cubo = 1;
            int cuarta = 1;
            Console.WriteLine("(: CUBO Y CUARTA :)");
            for (int i = 0; i < 11; i++) {
                Console.WriteLine("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());
                for (int j = 0; j<3;j++) {
                    cubo = cubo * num;
                }
                Console.WriteLine("El cubo de "+num+" es: "+cubo);
                cubo = 1;
                for (int j = 0; j < 4; j++)
                {
                    cuarta = cuarta * num;
                }
                Console.WriteLine("El cuarta de " + num + " es: " + cuarta);
                cuarta = 1;
            }
        }
        class StringBuilderTest
        {
            //Leer 10 números e imprimir solamente los números positivos
            //(Posible solución “Concatenar positivos e imprimirlos”)
            public static void Ejercicio3()
            {
                Console.Write("(: NUMEROS POSITIVOS :)\n");
                int num = 0;
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                Console.Write("Ingrese 10 numero: \n");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("El " + i + " es: ");
                    num = int.Parse(Console.ReadLine());
                    if (num > 0)
                    {
                        sb.AppendLine(num.ToString());
                    }
                }
                Console.WriteLine("Los numeros Positivos son: \n" + sb.ToString());
            }
            //Leer 15 números negativos y convertirlos a positivos e imprimir dichos números, 
            //de no ser negativo el sistema me volverá a pedir el número.
            public static void Ejercicio5()
            {
                Console.Write("(: NUMEROS NEGATIVOS:)\n");
                double num = 0;
                double posi = 0;
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                Console.Write("Ingrese 15 numero: \n");
                for (int i = 0; i < 15; i++)
                {
                    Console.Write("El " + i + " es: ");
                    num = int.Parse(Console.ReadLine());
                    if (num < 0)
                    {
                        posi = num * -1;
                        sb.AppendLine(posi.ToString());                     
                    }
                    else {
                        while (num >0) {
                            Console.WriteLine("Ingrese solo numeros negativos!\n");
                            Console.Write("El " + i + " es: ");
                            num = int.Parse(Console.ReadLine());
                        }
                    }
                }
                Console.WriteLine("Los numeros son: \n" + sb.ToString());
            }
        }
        //Leer 20 números e imprimir cuantos son positivos, cuantos negativos y cuantos neutros.
        public static void Ejercicio4()
        {
            Console.Write("(: CONTEO DE POSITIVOS; NEGATIVO Y NEUTROS :)\n");
            int num = 0;
            int contP = 0;
            int contNe = 0;
            int contN = 0;
            Console.Write("Ingrese 20 numero: \n");
            for (int i = 0; i < 20; i++)
            {
                Console.Write("El " + i + " es: ");
                num = int.Parse(Console.ReadLine());
                if (num == 0)
                {
                    contN++;
                }
                else if (num > 0)
                {
                    contP++;
                }
                else {
                    contNe++;
                }
            }
            Console.WriteLine("Hay " +contP+ " numero Positivos\n" );
            Console.WriteLine("Hay " + contNe + " numero Negativo\n");
            Console.WriteLine("Hay " + contN + " numero Neutro\n");
        }
       
        
    }
}
