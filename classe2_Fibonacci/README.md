# Documentação - Fibonacci

Este é um trecho de código em C# que gera uma sequência de Fibonacci com base no índice fornecido pelo usuário. 
O código solicita ao usuário o número de índices desejado, cria uma array com tamanho igual ao valor informado, 
preenche as duas primeiras posições da array com os valores iniciais da sequência (0 e 1) e, em seguida, calcula e exibe a sequência de Fibonacci.

## Funcionalidade

O código realiza as seguintes operações:

1. Solicita ao usuário o número de índices desejado para a sequência de Fibonacci.
2. Cria uma array `fib` com tamanho igual ao valor informado pelo usuário.
3. Inicializa as duas primeiras posições da array `fib` com os valores iniciais da sequência (0 e 1).
4. Preenche as posições restantes da array `fib` calculando a sequência de Fibonacci, somando os dois números anteriores.
5. Exibe a sequência de Fibonacci com base no número de índices fornecido.

## Uso

Para utilizar esse código, você precisa ter um ambiente de desenvolvimento C# configurado.

1. Copie o trecho de código fornecido para um arquivo C# com a extensão ".cs".
2. Compile e execute o arquivo C#.
3. Digite o número de índices desejado para a sequência de Fibonacci.
4. O programa irá calcular e exibir a sequência de Fibonacci até o índice fornecido.

## Exemplo de Saída

Exemplo 1:
```
Quantos índice para sequência de fibonacci? 10
0 1 1 2 3 5 8 13 21 34
```

Exemplo 2:
```
Quantos índice para sequência de fibonacci? 8
0 1 1 2 3 5 8 13
```

A saída acima exibe a sequência de Fibonacci com base no número de índices fornecido pelo usuário.

## Considerações Finais

Este código é um exemplo simples que gera a sequência de Fibonacci com base no número de índices fornecido. 
Ele demonstra o uso de uma array para armazenar os valores da sequência e o cálculo dos valores subsequentes com base nos dois valores anteriores. 
É possível adaptar esse código para atender a outras necessidades relacionadas à geração da sequência de Fibonacci.
