# Documentação - TrocarPosições

Este é um trecho de código em C# que preenche um vetor de tamanho 16 com números aleatórios e realiza a troca das primeiras 8 posições pelas últimas 8 posições. 
O código utiliza um gerador de números aleatórios para preencher o vetor e utiliza uma variável temporária para realizar a troca das posições.

## Funcionalidade

O código realiza as seguintes operações:

1. Cria um gerador de números aleatórios utilizando a classe `Random`, armazenando o resultado na variável `rand`.
2. Cria um vetor de tamanho 16 utilizando `int[] vet`.
3. Utiliza um loop `for` para preencher o vetor `vet` com 16 números aleatórios gerados.
4. A cada iteração do loop, gera um número aleatório entre 1 e 100 utilizando o método `Next()` da classe `Random` e atribui o resultado à variável `num`.
5. Atribui o valor de `num` à posição correspondente do vetor `vet`.
6. Utiliza um loop `foreach` para exibir os valores do vetor `vet` na ordem gerada.
7. Realiza a troca das primeiras 8 posições pelas últimas 8 posições do vetor utilizando um loop `for` e uma variável temporária `temp`.
8. Utiliza um loop `foreach` para exibir os valores do vetor `vet` após a troca das posições.

## Uso

Para utilizar esse código, você precisa ter um ambiente de desenvolvimento C# configurado.

1. Copie o trecho de código fornecido para um arquivo C# com a extensão ".cs".
2. Compile e execute o arquivo C#.
3. O programa irá preencher um vetor com 16 números aleatórios, exibir o vetor original e, em seguida, exibir o vetor após a troca das posições.

## Exemplo de Saída

Exemplo:
```
Array original: 67 91 5 28 49 78 3 42 63 89 56 94 17 72 13 99
Array trocadas: 63 89 56 94 17 72 13 99 67 91 5 28 49 78 3 42
```

A saída acima exibe o vetor original e o vetor após a troca das posições.

## Considerações Finais

Este código é um exemplo simples que preenche um vetor com números aleatórios e realiza a troca das primeiras 8 posições pelas últimas 8 posições. 
Ele utiliza um gerador de números aleatórios e uma variável temporária para realizar a troca. 
É possível adaptar esse código para atender a outras necessidades relacionadas à manipulação de vetores.
