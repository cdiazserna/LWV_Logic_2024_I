internal class Program
{
    private static void Main(string[] args)
    {
        /*Realice un programa que solicite dos números, luego debe pedirse un número que seleccionará alguna operación aritmética desde un menú. Si introduce 1 los números se deben sumar, si introduce 2 los números se deben restar, si es 3 los números se multiplican y si introduce 4 los números se dividen (validar división por cero). Independientemente de la selección, imprima el resultado. Además, el programa debe tener la posibilidad de volver al menú para pedir 2 nuevos números y hacer la elección de la operación aritmética o digitar cero para finalizar el programa. 
         */

        //Declaración de variables
        int option;
        double suma, resta, producto, cociente, num1, num2;
        //Flag para volver o salir del programa
        bool exit = false;

        do
        {
            Console.Clear();
            Console.WriteLine("Ingrese los dos números");
            num1 = Convert.ToDouble(Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n|------------MENÚ OPERACIONES ARITMÉTICAS------------|");
            Console.WriteLine("|Seleccione una operación aritmética para sus números|");
            Console.WriteLine("|----------------------------------------------------|");
            Console.WriteLine("|1. Suma                                             |");
            Console.WriteLine("|2. Resta                                            |");
            Console.WriteLine("|3. Multiplicación                                   |");
            Console.WriteLine("|4. División                                         |");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("|Digite 0 para salir                                 |");
            Console.WriteLine("|----------------------------------------------------|\n");
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 0:
                    exit = true;
                    break;
                case 1:
                    suma = num1 + num2;
                    Console.WriteLine(String.Format("{0} + {1} = {2}\n", num1, num2, suma));
                    Console.ReadKey(); // Para sostener mi programa hasta yo darle click
                    break;

                case 2:
                    resta = num1 - num2;
                    Console.WriteLine(String.Format("{0} - {1} = {2}\n", num1, num2, resta));
                    Console.ReadKey(); // Para sostener mi programa hasta yo darle click
                    break;

                case 3:
                    producto = num1 * num2;
                    Console.WriteLine(String.Format("{0} x {1} = {2}\n", num1, num2, producto));
                    Console.ReadKey(); // Para sostener mi programa hasta yo darle click
                    break;

                case 4:
                    if (num2 != 0)
                    {
                        cociente = num1 / num2;
                        Console.WriteLine(String.Format("{0} + {1} = {2}\n", num1, num2, cociente));
                        Console.ReadKey(); // Para sostener mi programa hasta yo darle click
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por cero\n");
                        Console.ReadKey(); // Para sostener mi programa hasta yo darle click
                    }
                    break;

                default:
                    Console.WriteLine($"La opción {option} no es válida. Digite una opción válida\n");
                    Console.ReadKey(); // Para sostener mi programa hasta yo darle click
                    break;
            }
        }
        while (!exit);
    }
}