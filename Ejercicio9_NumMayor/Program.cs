using System;

public class Program
{
    public static void Main(string[] args)
    {
        //Construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor de los números ingresados.
        // Solicitar numeros en pantalla

        Console.Write("Ingrese primer numero: ");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese segundo numero: ");
        double n2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese tercer numero: ");
        double n3 = Convert.ToDouble(Console.ReadLine());

        // Validar condiciones

        if (((n1 > n2) && (n2 > n3))) Console.Write("El mayor es:" + n1);
        else if (((n2 > n3) && (n3 > n1))) Console.Write("El mayor es: " + n2);
        else Console.Write("El mayor es: " + n3);
    }
}