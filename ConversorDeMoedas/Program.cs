using System.Globalization;

namespace ConversorDeMoedas;

internal class Program
{
    private static void Main()
    {
<<<<<<< HEAD
        Menu.Inicializar();
=======

        var dolar = 4.50;
        var euro = 6.20;
        var iene = 0.052;
        var libra = 6.95;

        //Cultura atual
        Console.WriteLine("\n--------- Exibindo conversão de cada moeda em Real ---------------\n");
        // Por padrão, o especificador de formato "C" exibe a mode até duas casas decimais
        Console.WriteLine("dólar em Reais " + dolar.ToString("C", CultureInfo.CurrentCulture));
        // C2 exibe a moeda até dois digitos
        Console.WriteLine("euro em Reais " + euro.ToString("C2", CultureInfo.CurrentCulture));
        // C3 exibe a moeda até 3 digitos
        Console.WriteLine("iene em Reais " + iene.ToString("C3", CultureInfo.CurrentCulture));
        // C4 exibe a moeda até 4 digitos
        Console.WriteLine("Reino Unido em Reais " + libra.ToString("C2", CultureInfo.CurrentCulture));

        var valor = 10;

        Console.WriteLine(Conversor.ToMoeda(Moeda.Dolar, valor));

>>>>>>> 369177b6b4efea5af8d4e282fc12322e8b69001c
    }

}