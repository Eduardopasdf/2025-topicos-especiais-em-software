using System;

class Exercicio05
{
    static void Main()
    {
        Console.Write("Digite um número inteiro positivo: ");
        int limite = Convert.ToInt32(Console.ReadLine());
        int a = 0, b = 1, temp;
        Console.Write("Sequência de Fibonacci: 0");
        while (b <= limite)
        {
            Console.Write($", {b}");
            temp = a + b;
            a = b;
            b = temp;
        }
        Console.WriteLine();
    }
}
