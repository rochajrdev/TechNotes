# Tipos de Texto em C#

## O que são Tipos de Texto?
Os tipos de texto em C# são utilizados para armazenar **sequências de caracteres** (letras, números, símbolos) ou **caracteres individuais**. C# fornece dois principais tipos para manipulação de texto:

1. `char` → Representa um único caractere.
2. `string` → Representa uma sequência de caracteres (texto).

---

## **1. Tipo `char`**
O tipo `char` armazena **apenas um caractere** e ocupa **2 bytes (16 bits)**, pois usa a codificação **Unicode**, permitindo armazenar caracteres especiais e de diferentes idiomas.

### **Exemplo de Uso**
```csharp
char letra = 'A';  
char simbolo = '#';  
char numero = '7';  
```
- O **valor de um `char` deve estar entre aspas simples (`'`)**.
- Cada `char` é internamente armazenado como um número inteiro correspondente à **tabela Unicode**.

### **Tabela de Exemplos**
| Caractere | Código Unicode |
|-----------|---------------|
| `'A'`     | `\u0041`      |
| `'B'`     | `\u0042`      |
| `'9'`     | `\u0039`      |
| `'@'`     | `\u0040`      |

### **Exemplo usando Unicode**
```csharp
char letraA = '\u0041';  // Representa 'A'
Console.WriteLine(letraA);  // Saída: A
```

### **Principais Métodos do `char`**
| Método               | Descrição |
|----------------------|-----------|
| `char.IsLetter(c)`   | Verifica se o caractere é uma letra. |
| `char.IsDigit(c)`    | Verifica se o caractere é um número. |
| `char.IsWhiteSpace(c)` | Verifica se o caractere é um espaço em branco. |
| `char.IsUpper(c)`    | Verifica se o caractere está em maiúsculo. |
| `char.IsLower(c)`    | Verifica se o caractere está em minúsculo. |

---

## **2. Tipo `string`**
O tipo `string` armazena **vários caracteres** (uma sequência de `char`), sendo amplamente utilizado para representar textos.

### **Exemplo de Uso**
```csharp
string nome = "Carlos";  
string mensagem = "Olá, seja bem-vindo!";  
```
- As strings são **imutáveis** em C#, ou seja, seu conteúdo **não pode ser modificado diretamente**.
- Para criar strings vazias, pode-se usar `string.Empty` ou `""`.

### **Propriedades do `string`**
| Propriedade      | Descrição |
|-----------------|-----------|
| `.Length`       | Retorna o número de caracteres na string. |
| `.Empty`        | Retorna uma string vazia (`""`). |
| `.Chars[index]` | Retorna o caractere na posição específica. |

### **Principais Métodos do `string`**
| Método                     | Descrição |
|----------------------------|-----------|
| `.ToUpper()`               | Converte para maiúsculas. |
| `.ToLower()`               | Converte para minúsculas. |
| `.Substring(início, comprimento)` | Extrai parte da string. |
| `.Replace("velho", "novo")` | Substitui partes do texto. |
| `.Trim()`                   | Remove espaços extras no início e no fim. |
| `.TrimStart()`              | Remove espaços do início da string. |
| `.TrimEnd()`                | Remove espaços do final da string. |
| `.Contains("texto")`        | Verifica se contém um determinado texto. |
| `.StartsWith("texto")`      | Verifica se a string começa com determinado valor. |
| `.EndsWith("texto")`        | Verifica se a string termina com determinado valor. |
| `.IndexOf("texto")`         | Retorna a posição do primeiro caractere da substring encontrada. |
| `.LastIndexOf("texto")`     | Retorna a posição da última ocorrência da substring. |
| `.Split('caractere')`       | Divide a string em um array com base em um delimitador. |
| `.Join("separador", array)` | Junta um array de strings em uma única string. |
| `.Equals(outraString)`      | Compara duas strings. |

### **Exemplos Práticos**
```csharp
string frase = " C# é incrível! ";
Console.WriteLine(frase.Length);  // Saída: 15
Console.WriteLine(frase.Trim());  // Saída: "C# é incrível!"
Console.WriteLine(frase.ToUpper());  // Saída: "C# É INCRÍVEL!"
Console.WriteLine(frase.Replace("incrível", "fantástico"));  // Saída: "C# é fantástico!"
```

---

## **3. Strings Verbatim (`@`)**
O prefixo `@` permite criar strings **multilinhas** e que ignoram caracteres de escape (`\`).

### **Exemplo de Uso**
```csharp
string caminho = @"C:\\Users\\Public\\Documents";
Console.WriteLine(caminho);
```
Saída:
```
C:\Users\Public\Documents
```

### **Strings Multilinhas**
```csharp
string mensagem = @"
Isso é um texto
com várias linhas
em C#";
Console.WriteLine(mensagem);
```

---

## **4. Interpolação de Strings (`$`)**
A interpolação (`$"..."`) permite inserir variáveis dentro de strings de forma prática.

### **Exemplo de Uso**
```csharp
string nome = "Carlos";
int idade = 25;

string mensagem = $"Meu nome é {nome} e tenho {idade} anos.";
Console.WriteLine(mensagem);
```
**Saída:**
```
Meu nome é Carlos e tenho 25 anos.
```

---

## **5. Concatenação de Strings**
Strings podem ser unidas de várias formas:

### **Usando `+`**
```csharp
string nome = "Ana";
string sobrenome = "Silva";
string nomeCompleto = nome + " " + sobrenome;
Console.WriteLine(nomeCompleto);
```
**Saída:** `Ana Silva`

### **Usando `string.Concat()`**
```csharp
string nomeCompleto = string.Concat(nome, " ", sobrenome);
```

### **Usando `string.Join()`**
```csharp
string[] palavras = { "C#", "é", "muito", "legal!" };
string frase = string.Join(" ", palavras);
Console.WriteLine(frase);
```
**Saída:** `C# é muito legal!`

---

## **Conclusão**
- O tipo `char` armazena **um único caractere**.
- O tipo `string` armazena **vários caracteres** e é amplamente usado para textos.
- Métodos como `.ToUpper()`, `.Replace()`, `.Substring()` são úteis para manipular strings.
- Strings podem ser concatenadas (`+`), interpoladas (`$"..."`) ou definidas em múltiplas linhas (`@`).
- Para comparar strings sem diferenciar maiúsculas e minúsculas, use `StringComparison.OrdinalIgnoreCase`.




