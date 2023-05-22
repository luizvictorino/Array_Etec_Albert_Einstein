// Classe: OrdenarArray


Random rand = new Random(); // cria gerador de numero aleatorio
int[] vet = new int[10];    // cria um vetor de tamanho 10

// inclue no vetor os 10 primeiros numeros gerados
for (int i = 0; i < vet.Length; i++)
{
    int num = rand.Next(1, 100);
    vet[i] = num;
}

// onverte os valores para string e exibe para o usuario os valores na ordem gerada
Console.Write("Ordem gerada: ");
foreach (var gerado in vet)
{
    Console.Write(gerado.ToString() + " ");
}

Array.Sort(vet);    // ordena o vetor em ordem crescente
Console.WriteLine();    // pula uma linha 

// exibe para o usuario os valores em ordem crescente
Console.Write("Ordem crescente: ");
foreach (int ordenado in vet)
{
    Console.Write(ordenado + " ");
}