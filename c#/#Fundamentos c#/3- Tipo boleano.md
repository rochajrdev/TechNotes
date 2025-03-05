# Tipo Booleano em C#

## O que é um Tipo Booleano?
O tipo **booleano** (`bool`) em C# representa um valor lógico que pode ser **verdadeiro (`true`)** ou **falso (`false`)**. Ele é usado principalmente em estruturas de controle como `if`, `while` e expressões condicionais.

---

## **Características do Tipo Booleano**
| Tipo  | Tamanho | Valores Possíveis | Explicação |
|-------|--------|------------------|------------|
| `bool` | 1 bit | `true` ou `false` | Representa um valor lógico verdadeiro ou falso. |

- O `bool` ocupa **1 bit** na memória, mas internamente pode ser armazenado com mais espaço dependendo do compilador e da arquitetura.
- Ele é amplamente utilizado em expressões de controle de fluxo e comparações.

---

## **Exemplos de Uso**
### **Usando `bool` em uma variável**
```csharp
bool estaChovendo = true;  // A variável recebe um valor booleano (Verdadeiro)
bool temSol = false;        // A variável recebe um valor booleano (Falso)
