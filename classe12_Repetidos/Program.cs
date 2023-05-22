// classe: Repetidos

Random rand = new Random(); // gera valores aleatorios
int[] vet = new int[100];   // cria um vetor com tamnho 100

// insere na array valores aleatorios entre 1 e 50
for (int i = 0; i < vet.Length; i++)
{
    vet[i] = rand.Next(1,50);
}

// exibe a array
foreach (var item in vet)
{
    Console.Write(item + " ");
}
Console.WriteLine();

// ordena array em ordem crescente
Array.Sort(vet);

Console.WriteLine("Valores que se repetem:");

// verifica se existem valores iguais e escreve os valores e as contagens, sem repetir
for (int i = 0; i < vet.Length; i++)
{
    int valor = vet[i];

    // se o valor já foi contado, passa para o próximo
    if (valor == -1)
    {
        continue;
    }

    int contagem = 0;

    // conta quantas vezes o valor aparece no array
    for (int j = i; j < vet.Length; j++)
    {
        if (vet[j] == valor)
        {
            contagem++;
            vet[j] = -1; // marca o valor como contado
        }
    }

    // se a contagem for maior que 1, o valor se repete
    if (contagem > 1)
    {
        Console.WriteLine($"{valor} ({contagem} vezes)");
    }
}