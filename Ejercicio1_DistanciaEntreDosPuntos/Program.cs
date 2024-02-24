using System;

namespace Ejercicio1_DistanciaEntreDosPuntos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lea las coordenadas de dos puntos y que muestre la distancia entre los dos puntos. 

            //Datos de Entrada: son 4 variables:
            //Declaración de variables
            double x1, x2, y1, y2, distancia;

            //Solicitud de datos por pantalla:
            Console.Write("Por favor digita el x1: ");
            x1 = double.Parse(Console.ReadLine());

            Console.Write("Por favor digita el y1: ");
            y1 = double.Parse(Console.ReadLine());

            Console.Write("Por favor digita el x2: ");
            x2 = double.Parse(Console.ReadLine());

            Console.Write("Por favor digita el y2: ");
            y2 = double.Parse(Console.ReadLine());

            //Proceso/Cálculo:
            distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            //Dato de salida:
            //Console.WriteLine("La distancia entre los pares ordenados (" + x1 + "," + y1 + ") y (" + x2 + "," + y2 + ") es = " + distancia);

            //otra forma más óptima para concatenar textos:
            Console.WriteLine(String.Format("La distancia entre los pares ordenados ({0},{1}) y ({2},{3}) es = {4}", x1, y1, x2, y2, distancia.ToString("N2")));
        }
    }
}
