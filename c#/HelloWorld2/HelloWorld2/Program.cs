using program2.teste; // importa o namespace program2.teste para que a classe Aleatorio possa ser usada no código

namespace program2;

class Program
{
    static void Main()  // método Main é o ponto de entrada de um programa C#
    {
       Carro meuCarro = new Carro(); // new é uma palavra-chave que cria uma instância de um objeto (neste caso, um objeto da classe Carro)

        meuCarro.Ligar(); // chama o método Ligar, que imprime "Carro LIGADO" no console

        meuCarro.Desligar(); // chama o método Desligar, que imprime "Carro DESLIGADO" no console

        Aleatorio meuAleatorio = new Aleatorio(); // cria uma instância da classe Aleatorio 

        meuAleatorio.Temperatura(); // chama o método Temperatura, que imprime "180C°" no console
    }
}
