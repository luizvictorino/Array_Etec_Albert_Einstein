# Documentação - ProcurarTodasOcorrencias

A classe `ProcurarTodasOcorrencias` é um trecho de código em C# que preenche um vetor de tamanho 100 com números aleatórios e busca 
todas as ocorrências de um valor informado pelo usuário no vetor. O código utiliza um loop `for` para percorrer o vetor e exibe os índices onde ocorre o valor pesquisado.

## Funcionalidade

O código realiza as seguintes operações:

1. Cria um gerador de números aleatórios utilizando a classe `Random`, armazenando o resultado na variável `rand`.
2. Cria um vetor de tamanho 100 utilizando `int[] vet`.
3. Solicita ao usuário que digite um número a ser pesquisado no vetor, armazenando o valor na variável `pesquisa`.
4. Utiliza um loop `for` para preencher o vetor `vet` com 100 números aleatórios gerados.
5. A cada iteração do loop, gera um número aleatório entre 1 e 100 utilizando o método `Next()` da classe `Random` e atribui o resultado à posição correspondente do vetor `vet`.
6. Exibe os valores do vetor `vet` para o usuário utilizando um loop `foreach`.
7. Utiliza um loop `for` para percorrer o vetor `vet` e verifica se o valor `pesquisa` é igual ao valor atual do vetor. Se sim, exibe o índice onde ocorre o valor pesquisado.
8. Se nenhuma ocorrência do valor pesquisado for encontrada, exibe uma mensagem informando que o valor não foi encontrado.

## Uso

Para utilizar esse código, você precisa ter um ambiente de desenvolvimento C# configurado.

1. Copie o trecho de código fornecido para um arquivo C# com a extensão ".cs".
2. Compile e execute o arquivo C#.
3. O programa irá solicitar que você digite um número a ser pesquisado no vetor. Em seguida, irá exibir os valores do vetor e os índices onde ocorre o valor pesquisado (caso existam).

## Exemplo de Saída

Exemplo:
```
Digite o numero que deseja pesquisar no vetor: 5
Array:
38 75 89 53 96 41 21 15 58 82 61 45 94 18 20 11 34 8 72 70 84 45 50 91 76 99 33 81 1 47 57 79 73 27 10 95 88 28 62 14 
50 11 45 52 84 63 95 15 79 73 62 94 4 29 35 68 22 6 67 93 70 7 73 34 19 42 64 40 49 9 47 96 22 34 60 62 79 22 90 47 97 
82 23 38 32 97 24 16 47 43 15 94 79 97 51 52 18 58 91 79 29 42 15 58 8 54 17 60

O valor 5 encontra-se nos indices:
34 48 77
```

A saída acima exibe os valores do vetor preenchido aleatoriamente e, em seguida, os índices

 onde ocorre o valor 5 no vetor.

## Considerações Finais

Este código é um exemplo simples que preenche um vetor com números aleatórios e busca todas as ocorrências de um valor no vetor utilizando um loop `for`. 
Ele demonstra como realizar uma pesquisa em um vetor e exibir todos os índices onde ocorre o valor pesquisado. 
É possível adaptar esse código para realizar outras operações de busca ou manipulação de vetores.
