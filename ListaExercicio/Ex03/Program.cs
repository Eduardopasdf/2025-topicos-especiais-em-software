using System;

class Exercicio03
{
    static void Main()
    {
        Console.Write("Digite o primeiro número inteiro: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o segundo número inteiro: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Maior número: {Math.Max(num1, num2)}");
        Console.WriteLine($"Menor número: {Math.Min(num1, num2)}");
    }
}
