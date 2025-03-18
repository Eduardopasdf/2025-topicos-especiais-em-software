int[] vetor = new int[100];
Random r = new Random();
for(int i = 0; i < vetor.Length; i++)
{
    vetor[i] = r.Next(100);
}

for (int i = 0; i < vetor.Length - 1; i++)
{
    for (int j = 0; j < vetor.Length - 1 - i; j++)
    {
        if (vetor[j] > vetor[j + 1])
        {
            
            int temp = vetor[j];
            vetor[j] = vetor[j + 1];
            vetor[j + 1] = temp;
        }
    }
}


for(int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}