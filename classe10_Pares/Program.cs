// classe: Pares

Random rand = new Random(); // cria um gerador de numero aleatorio
int[] vet = new int[40];    // cria um vetor de tamanho 40
int soma = 0;

// inclue no vetor os 40 numeros gerados
for (int i = 0; i < vet.Length; i++)
{
    vet[i] = rand.Next(1,100);
}

// verifica numeros pares a Array possui
for (int i = 0; i < vet.Length; i++)
{
    if (vet[i] % 2 == 0)
    {
        soma += 1;
    }
}

// exibe a quantidade de numeros pares e a Array
Console.WriteLine($"Na array essistem {soma} valores pares. \n");

foreach (var item in vet)
{
    Console.Write(item + " ");
}