// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

class Program
{
    static double CalcularMediaPonderada(double num1, double num2, double num3)
    {
        return (num1 * 2 + num2 * 3 + num3 * 5) / 10;
    }

    static void Main()
    {
        Console.Write("Digite a quantidade de casos de teste: ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            Console.Write("Digite três números separados por espaço: ");
            string[] valores = Console.ReadLine().Split();

            double numero1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double numero2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double numero3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double mediaPonderada = CalcularMediaPonderada(numero1, numero2, numero3);

            Console.WriteLine($"Média ponderada: {mediaPonderada:F1}");
        }
    }
}

