using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa el primer número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        int resultado = num1 + num2;

        Console.WriteLine("La suma es: " + resultado);
    }
}