//classe: Palindrome

Console.WriteLine("Digite uma palavra para verificar se é ou não palindrome.");
string palavra = Console.ReadLine()!;    //recebe palavra digitada pelo usuario

char[] caract = palavra.ToCharArray();  // converte a string para uma matriz de caracteres

Array.Reverse(caract);  // inverte os caracteres da matriz
string invertida = new string(caract);   // converte a matriz de caracteres para uma string

// exibe a palavra original e invertida digitada pelo usuario
Console.WriteLine($"Palavra original: {palavra}.");
Console.WriteLine($"Palavra invertida: {invertida} \n");


// verifica se a palavra digitada pelo usuario é palindrome
if (palavra == invertida)
{
    Console.WriteLine($"A palavra digitada é uma palindrome.");
}
else
{
    Console.WriteLine($"A palavra digitada não é palindrome.");
}