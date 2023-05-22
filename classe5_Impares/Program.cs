// classe: Impares

Random rand = new Random(); // cria um gerador de numero aleatorio
int[] classImpar = new int[10]; // cria um vetor de tamanho 10
int num = 0;

// inclue no vetor os 10 primeiros numeros impares gerados
for (int i = 0; i < classImpar.Length; i++)
{
    do
    {
        num = rand.Next(1, 100);
    } while(num % 2 == 0);

    classImpar[i] = num;
}

// exibe os valores do vetor 
foreach (var item in classImpar)
{
    Console.Write(item + " ");
}