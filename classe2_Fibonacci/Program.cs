// classe: Fibonacci

Console.Write("Quantos índice para sequência de fibonacci? ");
int indice = int.Parse(Console.ReadLine()!);

int[] fib = new int[indice];    // cria uma array como tamanho igual ao valor informado pelo usuário

fib[0] = 0; fib[1] = 1; // 1° e 2° posição iniciará com 0 e 1 sequencialmente

for (int i = 2; i < fib.Length; i++)
{
    fib[i] = fib[i-1] + fib[i-2];   // para cada posição, recebe a soma dos valores ddos dois numeros anteriores
}

foreach (var item in fib)
{
    // exibe a sequencia de finbonaccii como tamanho igual ao indice informado pelo pelo usuario
    Console.Write(item + " "); 
}