namespace AulaArrays
{
    class Program
{
        //Arrays:
        /*
         *static void Main(string[] args)
            { // Arrays são coleções de variáveis do mesmo tipo que são acessadas por um índice 
              // Declarando um array de inteiros
                int[] numeros = new int[5];
            // Atribuindo valores ao array
            numeros[0] = 10;
            numeros[1] = 20;
            numeros[2] = 30;
            numeros[3] = 40;
            numeros[4] = 50;
            // Exibindo os valores do array

            Console.WriteLine(numeros.LongLength); // Exibe o tamanho do array
            Console.WriteLine(numeros[0]);
            Console.WriteLine(numeros[1]);
            Console.WriteLine(numeros[2]);
            Console.WriteLine(numeros[3]);
            Console.WriteLine(numeros[4]);
        }*/

        // Listas:

        /*static void Main(string[] args)
        {
            // Listas são coleções de variáveis do mesmo tipo que são acessadas por um índice
            // Declarando uma lista de inteiros
            List<int> numeros = new List<int>();// não precisa definir o tamanho da lista pois ela é dinâmica e vai crescendo conforme a necessidade
            // Adicionando valores à lista
            numeros.Add(10);
            numeros.Add(20);
            numeros.Add(30);
            numeros.Add(40);
            numeros.Add(50);
            numeros.Remove(30); // remove o valor 30 da lista

            // Exibindo os valores da lista
            Console.WriteLine(numeros.Count); // Exibe o tamanho da lista
            Console.WriteLine(numeros[0]);
            Console.WriteLine(numeros[1]);
            Console.WriteLine(numeros[2]);
            Console.WriteLine(numeros[3]);
            Console.WriteLine(numeros[4]);
        } */

        // dictionary:
        /*
        static void Main(string[] args)
        {
            // Dictionary é uma coleção de pares chave/valor
            // Declarando um dicionário de inteiros
            Dictionary<string, int> numeros = new Dictionary<string, int>();
            // Adicionando pares chave/valor ao dicionário
            numeros.Add("um", 1);
            numeros.Add("dois", 2);
            numeros.Add("três", 3);
            numeros.Add("quatro", 4);
            numeros.Add("cinco", 5);
            // Exibindo os valores do dicionário
            Console.WriteLine(numeros.Count); // Exibe a quantidade de pares chave/valor
            Console.WriteLine(numeros["um"]);
            Console.WriteLine(numeros["dois"]);
            Console.WriteLine(numeros["três"]);
            Console.WriteLine(numeros["quatro"]);
            Console.WriteLine(numeros["cinco"]);
        }*/

        // hashset:
        static void Main()
        {
            // HashSet é uma coleção de valores únicos
            // Declarando um conjunto de inteiros
            HashSet<int> numeros = new HashSet<int>();
            // Adicionando valores ao conjunto
            numeros.Add(10);
            numeros.Add(20);
            numeros.Add(30);
            numeros.Add(40);
            numeros.Add(50);
            numeros.Add(10); // não será adicionado, pois o valor 10 já existe no conjunto
            // Exibindo os valores do conjunto
            Console.WriteLine(numeros.Count); // Exibe a quantidade de valores no conjunto
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
} 
