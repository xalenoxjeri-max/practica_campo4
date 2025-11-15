using System;

class Program
{
    static double CalcularArea(double baseRect, double altura)
    {
        return baseRect * altura;
    }

    static void Main()
    {
        Console.Write("Ingrese la base del rectángulo: ");
        double baseRect = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la altura del rectángulo: ");
        double altura = double.Parse(Console.ReadLine());

        double area = CalcularArea(baseRect, altura);

        Console.WriteLine("El área del rectángulo es: " + area);
    }
}

