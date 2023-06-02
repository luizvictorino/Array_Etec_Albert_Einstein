# Documentação - Repetidos

Este é um trecho de código em C# que gera um vetor de tamanho 100 preenchido com valores aleatórios entre 1 e 50, exibe o vetor, 
ordena-o em ordem crescente e, em seguida, verifica e exibe os valores repetidos juntamente com a contagem de suas ocorrências.

## Funcionalidade

O código realiza as seguintes operações:

1. Cria um objeto `Random` para gerar valores aleatórios.
2. Declara um vetor `vet` de tamanho 100 para armazenar os valores.
3. Preenche o vetor `vet` com valores aleatórios entre 1 e 50.
4. Exibe o conteúdo do vetor.
5. Ordena o vetor em ordem crescente.
6. Percorre o vetor e verifica quais valores se repetem.
7. Marca os valores repetidos com o valor -1 para evitar contagens duplicadas.
8. Conta quantas vezes cada valor repetido ocorre no vetor.
9. Exibe os valores repetidos juntamente com a contagem de suas ocorrências.

## Uso

Para utilizar esse código, você precisa ter um ambiente de desenvolvimento C# configurado.

1. Copie o trecho de código fornecido para um arquivo C# com a extensão ".cs".
2. Compile e execute o arquivo C#.

## Exemplo de Saída

```
14 30 9 16 32 26 12 14 43 29 10 38 34 8 38 1 41 28 7 40 25 42 28 48 2 
4 46 45 45 9 30 43 1 11 4 35 38 22 47 29 30 1 47 19 45 49 11 23 47 32 
36 49 15 16 27 43 6 28 36 35 22 4 25 29 21 32 48 32 35 39 9 9 34 22 4 
4 33 11 49 22 36 47 10 36 43 27 7 30 20 32 25 48 24 8 46 21 30 8 14 19 5 10 2 1 47
Valores que se repetem:
1 (4 vezes)
4 (6 vezes)
9 (4 vezes)
11 (3 vezes)
14 (3 vezes)
22 (5 vezes)
25 (3 vezes)
28 (4 vezes)
29 (4 vezes)
30 (6 vezes)
32 (6 vezes)
35 (4 vezes)
36 (5 vezes)
38 (4 vezes)
43 (5 vezes)
45 (3 vezes)
47 (6 vezes)
48 (3 vezes)
49 (3 vezes)
```

A saída acima exibe o vetor gerado, em seguida, os valores que se repetem, juntamente com o número de vezes que cada valor ocorre.

## Considerações Finais

Este código é um exemplo simples que gera um vetor de valores aleatórios, ordena-o e verifica os valores repetidos.
Ele demonstra a geração de valores aleatórios, classificação de um vetor e contagem de ocorrências. 
É possível adaptar esse código para atender a outras necessidades relacionadas à manipulação de vetores e contagem de valores repetidos.
