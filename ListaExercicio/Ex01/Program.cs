using System;

class Exercicio01
{
    static void Main()
    {
        Console.Write("Digite a altura do retângulo: ");
        double altura = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a largura do retângulo: ");
        double largura = Convert.ToDouble(Console.ReadLine());
        double area = altura * largura;
        Console.WriteLine($"Área do retângulo: {area}");
    }
}
