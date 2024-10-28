# Fibonacci e Contador de Caracteres em C#

Este programa em C# contém funções para verificar se um número pertence à sequência de Fibonacci e para contar a quantidade de vezes que a letra "a" (maiúscula ou minúscula) aparece em uma string fornecida pelo usuário.

## Estrutura do Código

O programa contém as seguintes funções:

- `Main`: Função principal que executa o programa e chama as funções `Teste1` e `Teste2`.
- `Teste1`: Pede ao usuário para inserir um número e verifica se ele pertence à sequência de Fibonacci, utilizando a função `PertenceFibonacci`.
- `PertenceFibonacci`: Recebe um número inteiro e verifica se ele pertence à sequência de Fibonacci.
- `Teste2`: Pede ao usuário para inserir uma frase e conta as ocorrências da letra "a" (em qualquer caso) utilizando a função `ContaOcorrenciasDeA`.
- `ContaOcorrenciasDeA`: Recebe uma string e conta a quantidade de vezes que "a" ou "A" aparece na string.
- `Teste3`: Função vazia reservada para futuras implementações.

## Como Funciona

### Funcionalidade 1: Verificar Pertinência à Sequência de Fibonacci

A função `Teste1` solicita ao usuário um número, que é processado pela função `PertenceFibonacci` para verificar se pertence à sequência de Fibonacci. A sequência é gerada com dois valores iniciais (`a = 0` e `b = 1`), e um loop acumula a soma dos dois últimos números até encontrar o número ou ultrapassá-lo. 

Se o número pertence à sequência, o programa imprime:
- O número X pertence à sequência de Fibonacci.
Caso contrário, ele imprime:
- O número X não pertence à sequência de Fibonacci.

### Funcionalidade 2: Contagem de Ocorrências da Letra "A" na String

A função `Teste2` solicita ao usuário uma frase, que é processada pela função `ContaOcorrenciasDeA`. A função verifica quantas vezes "a" ou "A" aparecem na string fornecida. O programa imprime o resultado em um dos dois formatos a seguir:
- Se houver ocorrências: A letra 'a' aparece Y vez(es) na string.
- Caso não haja ocorrências: A letra 'a' não aparece na string.

## Como Executar o Programa

1. Compile e execute o programa.
2. Insira um número quando solicitado para verificar se pertence à sequência de Fibonacci.
3. Insira uma frase quando solicitado para contar as ocorrências da letra "a".

## Exemplo de Saída

### Exemplo 1
- Entrada: 
- Informe um número: 8
- Saída: O número 8 pertence à sequência de Fibonacci.


### Exemplo 2
- Entrada:
- Informe uma frase: A aranha anda devagar
- Saída: A letra 'a' aparece 5 vez(es) na string.


## Notas

A função `Teste3` está vazia e reservada para futuras implementações.

## Autor
- João Pedro Pagotto da Costa
- email de contato: pagotto.costa@gmail.com

Este programa foi desenvolvido como um exemplo de operações com a sequência de Fibonacci e contagem de caracteres em C# como o teste tércnico para um programa de estágio.


