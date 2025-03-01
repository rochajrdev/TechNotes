# Conhecendo o Javascript e suas caracteristicas

* Linguagem de script orientada a objetos, multiplataforma, muito usado para a manipulação de elementos no Html.
* Javascript tem uma biblioteca padrão de objetos como: Array, Date e Math.
* Possui um conjunto de elementos que formam o núcleo da linguagem, como: operadores, estruturas de controle e declarações.
* Os  tipos de dados das variáveis não precisam ser declarados.
* Não pode escrever diretamente no disco rígido.
* Linguagem não compilada.

## O núcleo do Javascript:

**Cliente**: Fornece objetos para controlar um navegador web e seu **Document Object Model (DOM)**, eventos do usuário. Ou seja, você consegue manipular ações em um navegador utilizando o Javascript.

**Servidor**: Fornece objetos relevantes à execução do Javascript em um servidor. Operações com BD e arquivos. Isso se potencializou com a chegado do NodeJS.

### Padronização ECMAScript

São formas padrões de se escrever Javascript.

# Estrutura da linguagem Javascript

## Sintaxe de comandos em JavaScript

* É case-sensitive, ou seja, Maiuscula é diferente de Minuscula.
* Espaços, tabulação e uma nova linha são considerados espaçoes em branco.
* O código fonte dos scripts são lidos da esquerda para direita e são convertidos em sequência de elementos de entrada.
* Recomenda-se sempre adicionar ";" no final de suas declarações.
* Escolha nomes coerentes para o seu sistema.

## Comentários

comentrio de uma linha usa `//exemplo` e comentários de mais de uma linha usa `/*exemplo*/`

## Declarações

### Tipos:

* **var**: declara uma variável e a inicializa com um valor.
* **let**: declara uma variável local, escopo do bloco, a inicialização do valor é opcional.
* **const**: declara uma constante de ecopo do bloco, somente leitura.

Exemplos: 

```javascript
var nome = 
    "Maria";
//declaração local ou global
```
```javascript
sal = 1560;
//declaração global
```

```javascript
let idade = 22;
//declaração local(bloco)
```
## Identificadores de variáveis

**Regras para identificadores de variáveis:**

* Podem conter somente caracteres alfanuméricos (ou "$" ou "_").
* Não podem iniciar com um número.
* É "case-sensitive". Estado_origem **é diferente de** estado_origem.

Exemplos válidos:

`Nome_funcionário`, `_salario` e `$`

## Variável global

* Declara fora de uma função
* Disponível para todos os blocos

## Variável Local

* Declarada dentro de uma função
* Disponível apenas para a função onde foi declarada

## Constantes

* Após declarada ela não pode variar seu valor definido e nem ser declarada novamente enquanto o script estiver rodando.








