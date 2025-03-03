namespace OutrosTiposDeDados;

//enum são tipos de dados que permitem definir um conjunto de constantes nomeadas como por exemplo os dias da semana, os meses do ano, etc.
/*
class Program
{
    enum NivelDeDificuldade // Definindo um enum
    {
        Facil, // Cada item é separado por vírgula
        Medio, // Não é necessário atribuir um valor mas é possivivel
        Dificil // O valor padrão é 0, 1, 2, ...
    }
    // o enum tem as seguintes regras: 
    // 1. Não é possível ter dois itens com o mesmo nome
    // 2. Não é possível ter um item com o mesmo nome da enumeração
    // 3. Não é possível ter um item com o mesmo nome de um método
    // 4. Não é possível ter um item com o mesmo nome de uma variável
    // 5. Não é possível ter um item com o mesmo nome de uma classe
    // 6. Não é possível ter um item com o mesmo nome de um namespace
    // 7. Não é possível ter um item com o mesmo nome de um arquivo
    // 8. Não é possível ter um item com o mesmo nome de um diretório
    // 9. Não é possível ter um item com o mesmo nome de um projeto
    // 10. Não é possível ter um item com o mesmo nome de um assembly
    // 11. Não é possível ter um item com o mesmo nome de um namespace

    static void Main()
    {
        NivelDeDificuldade nivel = NivelDeDificuldade.Medio;
        Console.WriteLine(nivel); // Medio
    }


}
*/
// var é uma palavra-chave que permite que o compilador determine o tipo da variável com base no valor atribuído a ela.
/*
class Program2
{

    static void Main()
    {
        string nome = "Junior";
        int meuNumero = 10;

        Console.WriteLine(nome);

        var nome2 = "Junior"; // Permite que o compilador determine o tipo da variável automaticamente
        var meuNumero2 = 10; // Permite que o compilador determine o tipo da variável automaticamente
    }
*/
// Object: é um tipo de dado que é a base de todos os tipos de dados em C#.
/*
class Program3
{

    static void Main()
    {
        object meuObjeto = "Junior"; // Pode armazenar qualquer tipo de dado
        Console.WriteLine(meuObjeto); // Junior
        meuObjeto = 10;
        Console.WriteLine(meuObjeto); // 10

        // O tipo object é um tipo de referência, ou seja, ele armazena o endereço de memória onde o valor está armazenado.
        // a diferença entre o object e o var é que o object é um tipo de referência e o var é um tipo de valor.
    }
}
*/

// null: é um valor especial que indica que uma variável não tem valor.
class Program4
{
    // pode ser usado quando uma variável não tem um valor inicial
    static void Main()
    {
        int? idade = null; // Erro pois o tipo int não aceita valores nulos (int? é um tipo que aceita valores nulos)
        Console.WriteLine(idade); // null
    }
}