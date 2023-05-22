// classe: ProcurarTodasOcorrencias

Random rand = new Random(); // cria um gerador de numero aleatorio
int[] vet = new int[100];    // cria um vetor de tamanho 100

Console.Write("Digite o numero que deseja pesquisar no vetor: ");
int pesquisa = int.Parse(Console.ReadLine()!);   // valor a ser pesquisado no vetor

// vetor recebe 100 numeros aleatorios 
for (int i = 0; i < vet.Length; i++)
{
    vet[i] = rand.Next(1,100);
}

// exibe para o usuario
Console.WriteLine("Array:");
foreach (var item in vet)
{
    Console.Write(item + " ");
}
Console.WriteLine();

// retorna os indices da array onde ocorre o numero pesquisado
bool resp = false;

for (int i = 0; i < vet.Length; i++)
{
    if (pesquisa == vet[i])
    {
        Console.WriteLine($"O valor {pesquisa} encontra-se nos indices:");
        Console.Write($"{i} ");
        resp = true;
    }
}
if (!resp)
{
    Console.WriteLine($"Valor {pesquisa} não foi encontrado.");
}