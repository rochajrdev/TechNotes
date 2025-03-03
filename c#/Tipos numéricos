# Tipos Numéricos em C#


Em C#, os tipos numéricos são usados para armazenar e manipular números. Eles são divididos em tipos inteiros e tipos de ponto flutuante. A escolha do tipo depende do espaço de memória necessário e da precisão exigida para os cálculos.

## Tipos Numéricos Inteiros

Os tipos inteiros armazenam números sem casas decimais e variam em tamanho e faixa de valores permitidos.

| Tipo     | Tamanho | Faixa de Valores |
|----------|---------|------------------|
| `sbyte`  | 8 bits  | -128 a 127 |
| `byte`   | 8 bits  | 0 a 255 |
| `short`  | 16 bits | -32.768 a 32.767 |
| `ushort` | 16 bits | 0 a 65.535 |
| `int`    | 32 bits | -2.147.483.648 a 2.147.483.647 |
| `uint`   | 32 bits | 0 a 4.294.967.295 |
| `long`   | 64 bits | -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807 |
| `ulong`  | 64 bits | 0 a 18.446.744.073.709.551.615 |

### Exemplo de uso:
```csharp
int idade = 25;
long populacaoMundial = 8000000000;
byte nivelBateria = 85;
```

# Explicação detalhada sobre Tipos Numéricos em C#

## O que significam **Tamanho**, **Faixa de Valores** e os Tipos Numéricos?

### **Tamanho (bits)**
- Cada tipo numérico ocupa um certo espaço na memória do computador. Esse tamanho é medido em **bits** (unidades de informação).
- Quanto mais **bits**, maior a quantidade de números que ele pode armazenar.

### **Faixa de Valores**
- A **faixa de valores** representa o intervalo de números que aquele tipo pode armazenar.
- Tipos com **sinal** (como `int`, `short`, `long`, etc.) podem armazenar **números negativos e positivos**.
- Tipos **sem sinal** (`byte`, `ushort`, `uint`, `ulong`) armazenam apenas **valores positivos**.

---

## **Tabela de Tipos Numéricos**
| Tipo      | Tamanho  | Faixa de Valores | Explicação Simples |
|-----------|---------|------------------|--------------------|
| `sbyte`   | 8 bits  | -128 a 127       | Pequenos números, pode ser negativo. |
| `byte`    | 8 bits  | 0 a 255          | Pequenos números, só positivo. |
| `short`   | 16 bits | -32.768 a 32.767 | Valores um pouco maiores, pode ser negativo. |
| `ushort`  | 16 bits | 0 a 65.535       | Valores um pouco maiores, só positivo. |
| `int`     | 32 bits | -2.147.483.648 a 2.147.483.647 | Número inteiro mais usado na maioria dos programas. |
| `uint`    | 32 bits | 0 a 4.294.967.295 | Como o `int`, mas só positivo. Útil para contadores. |
| `long`    | 64 bits | -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807 | Para números muito grandes. |
| `ulong`   | 64 bits | 0 a 18.446.744.073.709.551.615 | Como o `long`, mas só positivo. |

---

## **Exemplos Práticos**
### **Número de alunos em uma escola**
```csharp
int alunos = 1200;  // O número de alunos pode ser negativo? Não. Mas pode crescer muito.
uint totalAlunos = 1200;  // Como nunca será negativo, podemos usar uint.

## Tipos Numéricos de Ponto Flutuante

Os tipos de ponto flutuante armazenam números com casas decimais e são úteis para cálculos matemáticos precisos.

| Tipo    | Tamanho | Precisão | Faixa de Valores |
|---------|---------|----------|------------------|
| `float`  | 32 bits | ~7 dígitos | ±1.5 × 10⁻⁴⁵ a ±3.4 × 10³⁸ |
| `double` | 64 bits | ~15-16 dígitos | ±5.0 × 10⁻³²⁴ a ±1.7 × 10³⁰⁸ |
| `decimal` | 128 bits | ~28-29 dígitos | ±1.0 × 10⁻²⁸ a ±7.9 × 10²⁸ |

### Diferenças entre `float`, `double` e `decimal`:
- `float`: Menos preciso, ocupa menos memória, indicado para gráficos e cálculos científicos.
- `double`: Mais preciso que `float`, usado para operações matemáticas de precisão moderada.
- `decimal`: Alta precisão, indicado para cálculos financeiros.

### Exemplo de uso:
```csharp
float temperatura = 36.5f;
double distancia = 384400.5; // Distância da Terra à Lua em km
decimal preco = 199.99m;
```

## Conversões entre Tipos Numéricos

### Conversão Implícita (automática)
Ocorre quando o tipo de destino pode armazenar todos os valores do tipo de origem sem perda de dados.

```csharp
int num = 100;
long numeroLongo = num; // Conversão automática de int para long
```

### Conversão Explícita (casting)
Necessária quando há risco de perda de dados.

```csharp
double valor = 9.7;
int inteiro = (int)valor; // Converte explicitamente, perdendo a parte decimal
```

### Uso de `Convert`
A classe `Convert` facilita conversões seguras.

```csharp
string textoNumero = "123";
int numero = Convert.ToInt32(textoNumero);
```

## Conclusão

C# oferece diversos tipos numéricos adequados para diferentes cenários. A escolha correta do tipo melhora a eficiência e precisão do código. Entender as conversões entre tipos é essencial para evitar erros e garantir cálculos precisos.

