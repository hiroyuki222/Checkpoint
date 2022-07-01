using System.Globalization;

namespace ConversorDeMoedas;

internal class Program
{
    private static void Main()
    { 
        //Cultura atual
        Console.WriteLine("\n--------- Exibindo conversão de cada moeda em Real ---------------\n");
        
        Console.WriteLine("dólar em Reais " + Math.Round(Conversor.ToReal(Moeda.Dolar,1),2));
        
        Console.WriteLine("euro em Reais " + Math.Round(Conversor.ToReal(Moeda.Euro,1),2));
        
        Console.WriteLine("iene em Reais " + Math.Round(Conversor.ToReal(Moeda.Iene,1),3 ));
        
        Console.WriteLine("libras em Reais " + Math.Round(Conversor.ToReal(Moeda.Libra,1),2));
        
        Menu.Inicializar();

    }

}