// classe: InverterPavra

Console.WriteLine("Digite uma palavra para ser invertida: ");
string palavra = Console.ReadLine()!;   // recebe palavra digitada pelo usuario

char[] caract = palavra.ToCharArray();  // converte a string para uma matriz de caracteres 

Array.Reverse(caract);  // inverte os caracteres da matriz
string invert = new string(caract); // converte a matriz de caracteres para uma string

// exibe a palavra original e invertida digitada pelo usuario
Console.WriteLine($"Original: {palavra}");
Console.WriteLine($"Invertida: {invert}");