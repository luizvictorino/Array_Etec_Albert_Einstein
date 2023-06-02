# Documentação - Ímpares

Este é um trecho de código em C# que gera e exibe os 10 primeiros números ímpares. 
O código utiliza um gerador de números aleatórios para criar um vetor de tamanho 10 e preenche esse vetor com os 10 primeiros números ímpares gerados.

## Funcionalidade

O código realiza as seguintes operações:

1. Cria um gerador de números aleatórios utilizando a classe `Random`, armazenando o resultado na variável `rand`.
2. Cria um vetor de tamanho 10 utilizando `int[] classImpar`.
3. Inicia uma variável `num` com o valor 0.
4. Utiliza um loop `for` para preencher o vetor `classImpar` com os 10 primeiros números ímpares gerados.
5. Dentro do loop `for`, utiliza um loop `do-while` para gerar números aleatórios entre 1 e 100 e atribuí-los à variável `num`. 
6. O loop `do-while` garante que apenas números ímpares sejam considerados, verificando se o número gerado é divisível por 2.
7. Atribui o valor de `num` à posição correspondente do vetor `classImpar`.
8. Utiliza um loop `foreach` para exibir os valores do vetor `classImpar`.

## Uso

Para utilizar esse código, você precisa ter um ambiente de desenvolvimento C# configurado.

1. Copie o trecho de código fornecido para um arquivo C# com a extensão ".cs".
2. Compile e execute o arquivo C#.
3. O programa irá gerar e exibir os 10 primeiros números ímpares.

## Exemplo de Saída

Exemplo:
```
9 27 35 59 5 17 13 95 87 79
```

A saída acima exibe os 10 primeiros números ímpares gerados.

## Considerações Finais

Este código é um exemplo simples que gera e exibe os 10 primeiros números ímpares. 
Ele utiliza um gerador de números aleatórios para garantir que apenas números ímpares sejam considerados. 
É possível adaptar esse código para atender a outras necessidades relacionadas à geração de números ímpares ou manipulação de vetores.
