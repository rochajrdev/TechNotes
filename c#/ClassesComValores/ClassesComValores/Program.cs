namespace ClassesComValores
{
    class Program
    {
        static void Main()
        {
            /*var carro = new carro();

            carro.modelo = "Fusca"; // posso acessar a propriedade modelo e alterar seu valor pois ela é publica
            carro.Cor = Cor.Azul; // posso acessar a propriedade Cor e alterar seu valor pois ela é publica
            carro.LançadoEm = new DateOnly(2021, 10, 10); // posso acessar a propriedade LançadoEm e alterar seu valor pois ela é publica

            */

            // outro modo de fazer:

            var carro = new carro
            {
                modelo = "Fusca",
                Cor = Cor.Azul,
                LançadoEm = new DateOnly(2021, 10, 10)
            };
            carro.modeloDoCarro();
        }
    }
}
