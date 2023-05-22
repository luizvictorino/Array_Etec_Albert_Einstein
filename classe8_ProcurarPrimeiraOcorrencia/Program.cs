// classe: ProcurarPrimeiraOcorrencia

Random rand = new Random(); // cria um gerador de numero aleatorio
int[] vet = new int[20];    // cria um vetor de tamanho 20

// insere os numeros no vetor
for (int i = 0; i < vet.Length; i++)
{
    vet[i] = rand.Next(1,20);
}

Console.Write("Digite o numero que deseja pesquisar no vetor: ");
int pesquisa = int.Parse(Console.ReadLine()!);   // valor a ser pesquisado no vetor

// retorna o indice referente valor pesquisado
int indice = Array.IndexOf(vet, pesquisa);

/* 
verifica se o valor pesquisado pertence ao vetor 
se Sim: retorna o indice da primeira ocorrencia do valor pesquisado
se Não: retorna que o valor não existe na ocorrência
*/
if (indice != -1)
{   
    Console.WriteLine($"A primeira ocorrência do valor {pesquisa} esta no indice {indice} do vetor. \n");
}
else
{   
    Console.WriteLine($"A ocorrência {pesquisa} não foi encontrada no vetor.");
}

// exibe para o usuario
foreach (var item in vet)
{
    Console.Write(item + " ");
}