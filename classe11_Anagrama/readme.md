# Documentação - Anagrama

Este é um trecho de código em C# que verifica se duas palavras digitadas pelo usuário são anagramas, ou seja, se possuem as mesmas letras, independentemente da ordem. O código converte as palavras em vetores de caracteres, exibe as palavras digitadas, verifica se as palavras têm o mesmo comprimento, ordena os vetores em ordem crescente e, por fim, compara os elementos dos vetores para determinar se são anagramas.

## Funcionalidade

O código realiza as seguintes operações:

1. Solicita ao usuário que digite duas palavras.
2. Converte as palavras em vetores de caracteres.
3. Exibe as palavras digitadas pelo usuário.
4. Verifica se as palavras têm o mesmo comprimento. Caso contrário, exibe a mensagem "As palavras não são anagrama" e encerra o programa.
5. Ordena os vetores de caracteres em ordem crescente.
6. Compara os elementos dos vetores para determinar se são anagramas. Caso encontre algum elemento diferente, exibe a mensagem "As palavras não são anagrama" e encerra o programa.
7. Caso nenhum elemento diferente seja encontrado, exibe a mensagem "As palavras são anagramas".

## Uso

Para utilizar esse código, você precisa ter um ambiente de desenvolvimento C# configurado.

1. Copie o trecho de código fornecido para um arquivo C# com a extensão ".cs".
2. Compile e execute o arquivo C#.
3. Digite as duas palavras quando solicitado pelo programa.
4. O programa irá verificar se as palavras são anagramas e exibirá o resultado.

## Exemplo de Saída

Exemplo 1:
```
Digite a primeira palavra:
listen
Digite a segunda palavra:
silent

Palavras: listen - silent
As palavras são anagramas.
```

Exemplo 2:
```
Digite a primeira palavra:
hello
Digite a segunda palavra:
world

Palavras: hello - world
As palavras não são anagramas.
```

A saída acima indica se as palavras digitadas pelo usuário são anagramas ou não.

## Considerações Finais

Este código é um exemplo simples que verifica se duas palavras são anagramas. Ele demonstra a conversão de strings em vetores de caracteres, ordenação de vetores e comparação de elementos. É possível adaptar esse código para atender a outras necessidades relacionadas à verificação de anagramas.
