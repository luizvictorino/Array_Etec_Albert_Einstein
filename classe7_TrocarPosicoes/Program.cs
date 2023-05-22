// classe: TrocarPosições

Random rand = new Random(); // cria um gerador de numero aleatorio
int[] vet = new int[16];    // cria um vetor de tamanho 16

int temp, num;

// inseri no vetor 16 numeros aleatorios
for (int i = 0; i < vet.Length; i++)
{
    num = rand.Next(1,100);
    vet[i] = num;
}

// exibe o vetor para o usuario na ordem gerada
Console.Write("Array original: ");
foreach (int original in vet)
{
    Console.Write(original + " ");
}

Console.WriteLine();

// troca as 8 prieiras posições pelas 8 ultimas
for (int i = 0; i < 8; i++)
{
    temp = vet[i];
    vet[i] = vet[i+8];
    vet[i+8] = temp;
}

// exibe a troca das 8 primeiras posição pela 8 ultimas 
Console.Write("Array trocadas: ");

foreach (int troca in vet)
{
    Console.Write(troca + " ");
}