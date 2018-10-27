using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Al cerrar un expendio de naranjas, 15 clientes que aún no han pagado recibirán un 15 % de descuento 
            //si compran más de 10 kilos.Determinar cuánto pagara cada cliente y cuanto percibirá la tienda por 
            //esas compras.

            double cantidad = 0;
            double descuento = 0;
            double precio = 100;
            double suma = 0;
            int conta = 0;
            while (conta <= 15)
            {
                Console.WriteLine("Cantidad de Kilos");
                cantidad = int.Parse(Console.ReadLine());
                if (cantidad > 10)
                {
                    descuento = (precio * cantidad) * 0.15;
                    suma = suma + ((precio * cantidad)-descuento);
                    Console.WriteLine("El valor a pagar por el cliente " + conta + " es: " + suma + " (" + cantidad + " kilos)\n");
                }
                else {
                    suma = suma + precio * cantidad;
                    Console.WriteLine("El valor a pagar por el cliente " + conta + " es: " + suma + " (" + cantidad + " kilos)\n");
                }
                conta = conta + 1;
            }
            Console.WriteLine("La ganancia de la tierra es: " + suma);
        }
    }
}
