using System;

class Exercicio02
{
    static void Main()
    {
        Console.Write("Digite o valor em reais (R$): ");
        double reais = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Dólar: ${(reais / 5.17):F2}");
        Console.WriteLine($"Euro: ${(reais / 6.14):F2}");
        Console.WriteLine($"Peso Argentino: ${(reais / 0.05):F2}");
    }
}
