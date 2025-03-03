using System.Text;

namespace TiposDeTexto;

class program
{
    static void Main()
    {
        // variaveis de tipos de texto
        // char

        char letra = 'a'; // para declarar um char, usamos aspas simples
        char numero = '1'; // podemos declarar numeros tambem desde que estejam entre aspas simples
        char simbolo = '@'; // podemos declarar simbolos tambem desde que estejam entre aspas simples

        // o char vai serguir a tabela ASCII, onde cada caractere tem um valor numerico

        // string

        string texto = "Isso é um texto"; // para declarar uma string, usamos aspas duplas, cada caractere da string é um char pois recebe um valor numerico da tabela ASCII iniciando em 0
        // funções de string:

        char primeiraLetra = texto[0]; // podemos acessar um caractere especifico de uma string atraves de seu indice
        Console.WriteLine(texto);
        Console.WriteLine(primeiraLetra);

        string meuNome = "   Adailson Junior   ";
        string nomeSemEspacos = meuNome.Trim(); // remove os espaços em branco do inicio e do fim da string e quando eu chamo a função Trim() eu preciso atribuir o resultado a uma variavel e ele vai retornar a string sem os espaços em branco exceto os que estiverem no meio da string
        Console.WriteLine(meuNome);
        Console.WriteLine(nomeSemEspacos);

        bool comecaComALetraA = nomeSemEspacos.StartsWith("A"); // verifica se a string começa com a letra A, ele diferencia maiusculas de minusculas
        bool terminaComALetraR = nomeSemEspacos.EndsWith("r"); // verifica se a string termina com a letra r, ele diferencia maiusculas de minusculas
        Console.WriteLine(comecaComALetraA);
        Console.WriteLine(terminaComALetraR);

        string textoAposReplace = nomeSemEspacos.Replace("Junior", "Rocha"); // substitui a palavra Junior por Rocha
        Console.WriteLine(textoAposReplace);

        bool existe = texto.Contains("texto"); // verifica se a string contem a palavra texto
        Console.WriteLine(existe);

        bool conferencia = texto.Equals("Isso é um texto"); // verifica se a string é exatamente igual a outra string
        Console.WriteLine(conferencia);

        // operações com strings:

        string paragrafo = texto + " " + textoAposReplace; // podemos concatenar strings
        Console.WriteLine(paragrafo);

        string paragrafo2 = $"A primeira frase é '{texto}' e a segunda é '{textoAposReplace}' ";
        Console.WriteLine(paragrafo2);

        StringBuilder stringBuilder = new StringBuilder(); // podemos usar o StringBuilder para manipular strings de forma mais eficiente

        stringBuilder.Append(texto); // adiciona texto ao StringBuilder
        stringBuilder.Append(textoAposReplace); // adiciona texto ao StringBuilder

        string paragrafo3 = stringBuilder.ToString(); // converte o StringBuilder em uma string

        Console.WriteLine(paragrafo3);









    }
}
