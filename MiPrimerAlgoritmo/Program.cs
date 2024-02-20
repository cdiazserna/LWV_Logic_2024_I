using System;

namespace MiPrimerAlgoritmo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Ingresar por pantalla 2 números y calcular las 4 operaciones aritméticas con dichos números. Mostrar en pantalla un mensaje de advertencia que indique que el segundo número debe ser diferente de 0. Imprimir en pantalla el resultado de cada operación.

            //Declaraciòn de variables
            double num1, num2;
            double sum, rest, prod, coc;
            string name;

            //leer num1
            Console.Write("Ingrese el primer nùmero: ");
            num1 = Convert.ToInt32(Console.ReadLine()); //Todo lo que ingrese en esta lìnea, serà tomado como un STRING
            Console.WriteLine(" ");
            //leer num1
            Console.Write("Ingrese el segundo nùmero. Este num debe ser diferente de 0: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            //Hacer los càlculos!
            sum = num1 + num2;
            rest = num1 - num2;
            prod = num1 * num2;
            coc = num1 / num2;

            //Imprimir en pantalla
            Console.WriteLine("Suma: " + num1 + " + " + num2 + " = " + sum); //1ra Forma para concatenar textos
            Console.WriteLine("Resta: " + num1 + " - " + num2 + " = " + rest);
            Console.WriteLine("Producto: " + num1 + " x " + num2 + " = " + prod);
            Console.WriteLine("Cociente: " + num1 + " / " + num2 + " = " + coc);
        }
    }
}
