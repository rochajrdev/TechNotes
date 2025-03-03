namespace TiposNumericos;

class Program
{
    static void Main()
    {
        // numweos inteiros
        int numero1 = 7; // int é um tipo de dado numérico inteiro que suporta valores de -2.147.483.648 a 2.147.483.647
        long numero2 = 7; // long é um tipo de dado numérico inteiro que suporta valores maiores como -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807

        uint numero3 = 7; // uint é um tipo de dado numérico inteiro que suporta valores de 0 a 4.294.967.295 usado para números inteiros positivos

        sbyte numero4 = 7; // sbyte é um tipo de dado numérico inteiro que suporta valores de -128 a 127

        byte numero5 = 7; // byte é um tipo de dado numérico inteiro que suporta valores de 0 a 255
        Console.WriteLine(numero3);

        // números decimais (pondo flutuante)

        double numero6 = 7.5; // double é um tipo de dado numérico decimal que suporta valores de 5.0 x 10^-324 a 1.7 x 10^308

        float numero7 = 7.5f; // float é um tipo de dado numérico decimal que suporta valores de 1.5 x 10^-45 a 3.4 x 10^38

        decimal numero8 = 7.5m; // decimal é um tipo de dado numérico decimal que suporta valores de 1.0 x 10^-28 a 7.9 x 10^28

        Console.WriteLine(numero8);

        // difereça entre float, double e decimal é a precisão e o tamanho da memória que cada um ocupa
    }
}