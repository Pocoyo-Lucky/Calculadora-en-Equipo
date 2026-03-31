using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa el numerador: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Ingresa el denominador: ");
        double num2 = double.Parse(Console.ReadLine());

        double resultado = num1 / num2;

        Console.WriteLine("La división es: " + resultado);
    }
}
