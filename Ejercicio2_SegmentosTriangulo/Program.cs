
public class Program
{
    private static void Main(string[] args)
    {
        //Lea la longitud de tres segmentos y que muestre si se puede construir un triángulo con estos segmentos.

        //Declaración de variables:
        double seg1, seg2, seg3;
        string mensaje = "se puede construir un triángulo";

        //Pedir los datos:
        Console.Write("SEGMENTO POSITIVOS\n");
        Console.Write("Ingrese el primer segmento: ");
        seg1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("\nIngrese el segundo segmento: ");
        seg2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("\nIngrese el tercer segmento: ");
        seg3 = Convert.ToDouble(Console.ReadLine());

        //Validar:
        if ((seg1 + seg2) > seg3)
        {
            if ((seg1 + seg3) > seg2)
            {
                if ((seg2 + seg3) > seg1)
                {
                    Console.WriteLine(String.Format("1Sí {0}", mensaje));
                }
                else
                {
                    Console.WriteLine(String.Format("1No {0}", mensaje));
                }

            }
            else
            {
                Console.WriteLine(String.Format("1No {0}", mensaje));
            }

        }
        else
        {
            Console.WriteLine(String.Format("1No {0}", mensaje));
        }



        if (((seg1 + seg2) > seg3) && ((seg1 + seg3) > seg2)  && ((seg2 + seg3) > seg1))
        {
            Console.WriteLine(String.Format("2Sí {0}", mensaje));
        }
        else
            Console.WriteLine(String.Format("2No {0}", mensaje));
    }
}