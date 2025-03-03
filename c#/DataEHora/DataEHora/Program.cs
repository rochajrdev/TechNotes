namespace DataEHora;

class Program
{
    static void Main()
    {
        DateOnly dia = new DateOnly(2021, 12, 31);
        string diaEmtexto = dia.ToLongDateString();

        Console.WriteLine(diaEmtexto);

        DateTime dataHora = new DateTime(2021, 12, 31, 23, 59, 59);
        Console.WriteLine(dataHora);

        DateTime hoje = DateTime.UtcNow;
        Console.WriteLine(hoje);

        DateTime novaData = dataHora.AddDays(1);
        Console.WriteLine(novaData);
    }
}
