// classe: Media

double[] notas = new double[4]; // cria uma array com tamanho 4
double media = 0;   // cria uma variavel media que inicia com valor = 0

// a cada interação deve ser informado cada nota
for (int i = 0; i < notas.Length; i++)
{
    Console.Write($"Informe a {i + 1}° nota: ");
    notas[i] = double.Parse(Console.ReadLine()!);   // inclue a nota em cada posição da array
}

for (int i = 0; i < notas.Length; i++)
{
    media += notas[i] / 4;  // calcula a media do aluno
}

// exibe a media final do aluno 
Console.WriteLine($"Sua média foi de {media.ToString("F2")}.");