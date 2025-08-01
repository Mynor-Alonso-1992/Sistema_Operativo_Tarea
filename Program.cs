using System;

class Program
{
    static int Sumar(int x, int y)
    {
        return x + y;
    }

    static int Restar(int x, int y)
    {
        return x - y;
    }

    static void Main(string[] args)
    {
        Console.Write("Ingrese el primer número: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.Write("Opción: ");
        string opcion = Console.ReadLine();

        if (opcion == "1")
        {
            Console.WriteLine("Resultado: " + Sumar(a, b));
        }
        else if (opcion == "2")
        {
            Console.WriteLine("Resultado: " + Restar(a, b));
        }
        else
        {
            Console.WriteLine("Opción no válida.");
        }
    }
}
