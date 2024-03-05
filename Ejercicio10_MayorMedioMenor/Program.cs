public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("*****Solución Juan Urrea*******");

        //Construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor, el del medio y el menor de los números ingresados.

        //Declaración de Variables

        double n1, n2, n3;

        //Pedir datos al usuario

        Console.WriteLine("Ingrese el primer número: ");
        n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número: ");
        n2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el tercer número: ");
        n3 = Convert.ToDouble(Console.ReadLine());

        //Validacion de datos

        if((n1 > n2) && (n2 > n3))
        {
            Console.WriteLine("El numero mayor es:" + n1);
            Console.WriteLine("El numero medio es:" + n2);
            Console.WriteLine("El numero menor es:" + n3);
        }
        else if ((n2 > n1) && (n1 > n3))
        {
            Console.WriteLine("El numero mayor es: " + n2);
            Console.WriteLine("El numero medio es: " + n1);
            Console.WriteLine("El numero menor es: " + n3);
        }
        else if ((n3 > n2) && (n2 > n1))
        {
            Console.WriteLine("El numero mayor es: " + n3);
            Console.WriteLine("El numero medio es: " + n2);
            Console.WriteLine("El numero menor es: " + n1);
        }
        else
        {
            Console.WriteLine("Hay numeros que son iguales.");
        }

        Console.WriteLine("***************************");

        Console.WriteLine("*******Solución Diego Giraldo*******");

        int number1, number2, number3;

        Console.Write("Ingresa el primer número: ");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa el tercer número: ");
        number3 = Convert.ToInt32(Console.ReadLine());

        if (number1 >= number2)
        {
            if (number2 > number3) Console.WriteLine($"el {number1} es mayor, el {number2} el del medio y {number3} el menor");
            else Console.WriteLine($"el {number1} es mayor, el {number3} el del medio y {number2} el menor");
        }
        else if (number2 >= number3)
        {
            if (number1 > number3) Console.WriteLine($"el {number2} es mayor, el {number1} el del medio y {number3} el menor");
            else Console.WriteLine($"el {number2} es mayor, el {number3} el del medio y {number1} el menor");

        }
        else if (number3 >= number1)
        {
            if (number1 > number2) Console.WriteLine($"el {number3} es mayor, el {number1} el del medio y {number2} el menor");
            else Console.WriteLine($"el {number3} es mayor, el {number2} el del medio y {number1} el menor");
        }
        else
        {
            Console.WriteLine("Todos los numeros son iguales");
        }
    }
}