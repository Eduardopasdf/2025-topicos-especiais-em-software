﻿using System;

class Exercicio04
{
    static void Main()
    {
        Console.Write("Digite sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());
        if (idade <= 13)
            Console.WriteLine("Criança");
        else if (idade <= 18)
            Console.WriteLine("Adolescente");
        else if (idade <= 60)
            Console.WriteLine("Adulto");
        else
            Console.WriteLine("Idoso");
    }
}
