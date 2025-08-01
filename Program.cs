using System;

class Program
{
    static int Sumar(int x, int y)
    {
        return x + y;
    }

    static void Main(string[] args)
    {
        Console.Write("Ingrese el primer número: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("La suma es: " + Sumar(a, b));
    }
}
