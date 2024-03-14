public class Program
{
    private static void Main(string[] args)
    {
        //Construir un algoritmo que pida N números por pantalla, cuando el usuario ingrese un número negativo, el programa debe finalizar y mostrar en consola la cantidad total de números positivos que ingresó hasta antes de ingresarse el número negativo. 

        //FORMA 1
        //VARIABLES DE ENTRADA:
        int num, contador = 0;
        bool validador = true;

        //Creación del ciclo
        while (validador) //Flag
        {
            Console.Write("Ingrese un número: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num < 0) validador = false;
            else contador = contador + 1;
        }

        //FORMA 2 - DIEGO GAVIRIA
        //Primero, omito la creación de una variable de estado o flag (omito declarar la var validador

        //Segudo, en el while, directamente coloco la palabra reservada "true"
        //Pero ojo, este true, si no va con una palabra reservada "break", se generará un bucle infinito.
        //Creación del ciclo
        while (true) //Flag
        {
            Console.Write("Ingrese un número: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num < 0)
            {
                break; //Quiébreme el while porque ya no puede volver a entrar
            }
            else
            {
                contador = contador + 1;
            }
        }


        Console.WriteLine(String.Format("El total de números positivos ingresados es de: {0}", contador));
    }
}