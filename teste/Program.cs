
// Entrada das palavras para compraração 
Console.Write("Digite uma palavra: ");
string palavra1 = Console.ReadLine()!;

Console.Write("Digite a segunda palavra: ");
string palavra2 = Console.ReadLine()!;

// Verifica se as palavras tem o mesmo comprimento
if (palavra1.Length != palavra2.Length)
{
    Console.WriteLine("As palavras não são anagramas");
    return;
}

// faz a comparação de cada elemento da palavra1 com a palavra2
for (int i = 0; i < palavra1.Length; i++)
{
    for (int j = 0; j < palavra2.Length; i++)
    {
        if (palavra1[i] == palavra2[j])
        {

        }
    }

    Console.WriteLine("TEste");
}