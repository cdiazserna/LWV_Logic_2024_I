internal class Program
{
    private static void Main(string[] args)
    {
        int num1, num2, numMenor, numMayor;
        Console.Write("Digite el primer numero: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite el segundo numero: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
        numMenor = num2;
        numMayor = num1;
        }
        else
        {
        numMenor = num1;
        numMayor = num2;
        }

        Console.Write("\n");

        for (int i = numMenor; i <= numMayor; i++)
        Console.Write(i + " ");

        Console.Write("\n");
    }

}