# Documentação - ProcurarPrimeiraOcorrencia

A classe `ProcurarPrimeiraOcorrencia` é um trecho de código em C# que preenche um vetor de tamanho 20 com números aleatórios e busca a 
primeira ocorrência de um valor informado pelo usuário no vetor. O código utiliza a função `IndexOf` da classe `Array` para realizar a busca.

## Funcionalidade

O código realiza as seguintes operações:

1. Cria um gerador de números aleatórios utilizando a classe `Random`, armazenando o resultado na variável `rand`.
2. Cria um vetor de tamanho 20 utilizando `int[] vet`.
3. Utiliza um loop `for` para preencher o vetor `vet` com 20 números aleatórios gerados.
4. A cada iteração do loop, gera um número aleatório entre 1 e 20 utilizando o método `Next()` da classe `Random` e atribui o resultado à posição correspondente do vetor `vet`.
5. Solicita ao usuário que digite um número a ser pesquisado no vetor, armazenando o valor na variável `pesquisa`.
6. Utiliza a função `IndexOf` da classe `Array` para buscar a primeira ocorrência do valor `pesquisa` no vetor `vet` e armazena o resultado na variável `indice`.
7. Verifica se o valor `pesquisa` foi encontrado no vetor. Se sim, exibe a mensagem informando o índice da primeira ocorrência. 
    Se não, exibe a mensagem informando que o valor não foi encontrado.
9. Utiliza um loop `foreach` para exibir os valores do vetor `vet` para o usuário.

## Uso

Para utilizar esse código, você precisa ter um ambiente de desenvolvimento C# configurado.

1. Copie o trecho de código fornecido para um arquivo C# com a extensão ".cs".
2. Compile e execute o arquivo C#.
3. O programa irá preencher um vetor com 20 números aleatórios, solicitará que você digite um número a ser pesquisado no vetor e, 
    em seguida, exibirá o índice da primeira ocorrência do valor pesquisado (caso exista) e os valores do vetor.

## Exemplo de Saída

Exemplo:
```
Digite o numero que deseja pesquisar no vetor: 10
A primeira ocorrência do valor 10 esta no indice 4 do vetor.

1 6 17 12 10 3 8 19 2 13 15 6 10 8 17 4 1 11 10 16
```

A saída acima exibe a primeira ocorrência do valor 10 no índice 4 do vetor, bem como os valores do vetor preenchido aleatoriamente.

## Considerações Finais

Este código é um exemplo simples que preenche um vetor com números aleatórios e busca a primeira ocorrência de um valor no vetor utilizando a função `IndexOf`. 
Ele demonstra como realizar uma pesquisa em um vetor e exibir o índice da primeira ocorrência do valor pesquisado. 
É possível adaptar esse código para realizar outras operações de busca ou manipulação de vetores.
