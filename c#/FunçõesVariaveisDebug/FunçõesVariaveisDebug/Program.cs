namespace FunçõesVariaveisDebug
{
    class Program
    {
        static void Main()
        {
            var matematica = new operacoesMatematicas();

            //matematica.Adicionar(10, 20);
            var resultado = matematica.Adicionar(valor1: 10, valor2: 20);

            Console.WriteLine(resultado);
            Console.WriteLine(resultado.resultadoDaAdicao);

            matematica.Teste(10);
        }
    }
}

