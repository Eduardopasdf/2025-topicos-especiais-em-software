using System;

class Program
{
    static void Main()
    {
        int[] vetor = new int[100];  // Cria um vetor de inteiros com 100 posições
        Random r = new Random();     // Instancia um gerador de números aleatórios
        
        // Preenche o vetor com números aleatórios de 0 a 99
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = r.Next(100);
        }

        // Ordena o vetor em ordem crescente
        Array.Sort(vetor);

        // Exibe os números ordenados no console
        foreach (int num in vetor)
        {
            Console.Write(num + " ");
        }
    }
}
