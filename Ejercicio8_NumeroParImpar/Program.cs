//Construir un programa que pida un número y luego diga si este número es par o no.
//Declaramos las variables

int num;
string mensaje = "El número ingresado es ";

//Realizamos la solicitud del número en la consola
Console.Write("Por favor digite un número mayor a 0: ");
num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) Console.Write(mensaje + "par");
else Console.Write(mensaje + "Impar");