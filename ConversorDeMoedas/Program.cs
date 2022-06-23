namespace ConversorDeMoedas;

internal class Program
{
    private static void Main()
    {
        var valor = 10;

        Console.WriteLine(Conversor.ToMoeda(Moedas.Dolar, valor));
    }
}