# Documentação - OrdenarArray

Este é um trecho de código em C# que gera um vetor de 10 números aleatórios e os exibe tanto na ordem gerada quanto em ordem crescente. 
O código utiliza um gerador de números aleatórios para preencher o vetor e, em seguida, utiliza o método `Array.Sort()` para ordenar os valores do vetor em ordem crescente.

## Funcionalidade

O código realiza as seguintes operações:

1. Cria um gerador de números aleatórios utilizando a classe `Random`, armazenando o resultado na variável `rand`.
2. Cria um vetor de tamanho 10 utilizando `int[] vet`.
3. Utiliza um loop `for` para preencher o vetor `vet` com 10 números aleatórios gerados.
4. A cada iteração do loop, gera um número aleatório entre 1 e 100 utilizando o método `Next()` da classe `Random` e atribui o resultado à variável `num`.
5. Atribui o valor de `num` à posição correspondente do vetor `vet`.
6. Utiliza um loop `foreach` para exibir os valores do vetor `vet` na ordem gerada.
7. Utiliza o método `Array.Sort()` para ordenar os valores do vetor `vet` em ordem crescente.
8. Exibe os valores do vetor `vet` em ordem crescente.

## Uso

Para utilizar esse código, você precisa ter um ambiente de desenvolvimento C# configurado.

1. Copie o trecho de código fornecido para um arquivo C# com a extensão ".cs".
2. Compile e execute o arquivo C#.
3. O programa irá gerar um vetor de 10 números aleatórios e exibi-los tanto na ordem gerada quanto em ordem crescente.

## Exemplo de Saída

Exemplo:
```
Ordem gerada: 45 73 12 64 8 91 55 19 36 27
Ordem crescente: 8 12 19 27 36 45 55 64 73 91
```

A saída acima exibe os valores do vetor tanto na ordem gerada quanto em ordem crescente.

## Considerações Finais

Este código é um exemplo simples que gera um vetor de números aleatórios e os ordena em ordem crescente. 
Ele utiliza um gerador de números aleatórios e o método `Array.Sort()` para realizar a ordenação. 
É possível adaptar esse código para atender a outras necessidades relacionadas à geração e ordenação de vetores.
