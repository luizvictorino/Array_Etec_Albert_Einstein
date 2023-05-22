// classe: Anagrama

// recebe palavra digitada pelo usuario
Console.WriteLine("Digite a primeira palavra:");
string palavra1 = Console.ReadLine()!;
Console.WriteLine("Digite a segunda palavra:");
string palavra2 = Console.ReadLine()!;

Console.WriteLine();

// converte em Array de caracteres
char[] vet1 = palavra1.ToCharArray();
char[] vet2 = palavra2.ToCharArray();

// exibe as palavras digitados pelo usuario
Console.Write("Palavras: ");
foreach (var item in vet1)
{
    Console.Write(item);
}

Console.Write(" - ");
foreach (var item in vet2)
{
    Console.Write(item);
}
Console.WriteLine();

// verifica se as palavras tem o mesmo comprimento
if (vet1.Length != vet2.Length)
{
    Console.WriteLine("As palavras não são anagrama");
    return;
}

// ordena as palavras em ordem crescente
Array.Sort(vet1);
Array.Sort(vet2);

// faz a comparação de cada elemento do vetores
for (int i = 0; i < vet1.Length; i++)
{
    if (vet1[i] != vet2[i])
    {
        Console.WriteLine("As palavras não são anagrama");
        return;
    }
}

Console.WriteLine("As palavras são anagramas. \n");