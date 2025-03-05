
namespace ClassesComValores
{
    public class carro
    {
        // Definindo propriedades:
        public required string modelo { get; set; } // define a propriedade model e get e set significa que pode ser acessado e alterado respectivamente/ o required torna obrigatório o preenchimento do campo
        public DateOnly LançadoEm { get; set; }
        public Cor Cor { get; set; }

        // Definindo funções:
        /* public void modeloDoCarro()
         {
             Console.WriteLine($"O modelo do carro é {modelo}");
         }*/
        public void modeloDoCarro() => Console.WriteLine($"O modelo do carro é {modelo}");
    }
}