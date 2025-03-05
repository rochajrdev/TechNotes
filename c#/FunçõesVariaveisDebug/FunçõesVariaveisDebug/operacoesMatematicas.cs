
namespace FunçõesVariaveisDebug;

public class operacoesMatematicas
{
    /*public void Adicionar(int valor1, int valor2)
    {
        var resultado = valor1 + valor2;

        Console.WriteLine(resultado);
    }*/ 
    
    /*public int Adicionar(int valor1, int valor2) // Alterado para retornar um inteiro
    { //o que essa função está fazendo é somar dois valores inteiros e retornar o resultado
        return valor1 + valor2; // soma os valores e retorna o resultado
    }*/
    // outra forma:
    //public int Adicionar(int valor1, int valor2) => valor1 + valor2; // soma os valores e retorna o resultado

    // para retornar mais de um valor em uma função:
    public (int, string) Adicionar(int valor1, int valor2)
    {
        var resultado = valor1 + valor2;
        var mensagem = "A soma dos valores é: " + resultado;
        return (resultado, mensagem);
    }
}


