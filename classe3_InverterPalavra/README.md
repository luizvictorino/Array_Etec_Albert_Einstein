# Documentação - Inverter Palavra

Este é um trecho de código em C# que solicita ao usuário uma palavra, inverte a palavra digitada e exibe tanto a palavra original quanto a palavra invertida.

## Funcionalidade

O código realiza as seguintes operações:

1. Solicita ao usuário que digite uma palavra.
2. Armazena a palavra digitada pelo usuário na variável `palavra`.
3. Converte a string `palavra` em uma matriz de caracteres utilizando o método `ToCharArray()`, armazenando o resultado na variável `caract`.
4. Inverte os caracteres da matriz `caract` utilizando o método `Reverse()` da classe `Array`.
5. Converte a matriz de caracteres `caract` de volta para uma string utilizando o construtor `new string(caract)`, armazenando o resultado na variável `invert`.
6. Exibe a palavra original digitada pelo usuário utilizando a string `palavra`.
7. Exibe a palavra invertida utilizando a string `invert`.

## Uso

Para utilizar esse código, você precisa ter um ambiente de desenvolvimento C# configurado.

1. Copie o trecho de código fornecido para um arquivo C# com a extensão ".cs".
2. Compile e execute o arquivo C#.
3. Digite uma palavra quando solicitado.
4. O programa irá inverter a palavra digitada e exibir tanto a palavra original quanto a palavra invertida.

## Exemplo de Saída

Exemplo:
```
Digite uma palavra para ser invertida:
Hello

Original: Hello
Invertida: olleH
```

A saída acima exibe a palavra original digitada pelo usuário ("Hello") e a palavra invertida ("olleH").

## Considerações Finais

Este código é um exemplo simples que inverte uma palavra digitada pelo usuário. 
Ele demonstra a conversão de uma string em uma matriz de caracteres, a inversão dos caracteres da matriz e a conversão da matriz de caracteres de volta para uma string. 
É possível adaptar esse código para atender a outras necessidades relacionadas à manipulação de strings.
