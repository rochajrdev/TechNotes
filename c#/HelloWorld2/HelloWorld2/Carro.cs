namespace program2;

class Carro 
{
    public void Ligar() // public é um modificador de acesso que permite que o método seja acessado de qualquer lugar
    {
        Console.WriteLine("Carro LIGADO");
    }

    public void Desligar()
    {
        Console.WriteLine("Carro DESLIGADO");
    }

    private void Teste1()
    {
        Console.WriteLine("Carro DESLIGADO");
    }

    internal void Teste2()
    {
        Console.WriteLine("Carro DESLIGADO");
    }
}

