


namespace ConversorDeMoedas;
internal static class Menu
{

    public static int MenuDeMoedas()
    {
        Console.WriteLine(
                "1 - Real\n" +
                "2 - Dolar\n" +
                "3 - Euro\n" +
                "4 - Iene\n" +
                "5 - Libra");
        return int.Parse(Console.ReadLine());
    }
   
    public static void CasosDeConversao(int moedaUtilizada, int moedaParaQualConvertera, decimal valor)
    {
        if(moedaParaQualConvertera == 1)
        {
            Console.WriteLine($"O valor convertido é {Conversor.ToReal(TipoDeMoeda(moedaUtilizada),valor)}");
        }
        else
        {
            Console.WriteLine(Conversor.ToMoeda(TipoDeMoeda(moedaUtilizada), Conversor.ToReal(Moedas.Real,valor)));
        }
        
    }
    //<summary>
    //Retorna o tipo da moeda
    //<summary>
    public static Moedas TipoDeMoeda(int moedaUtilizada)
    {
        if(moedaUtilizada == 1)
        {
            return Moedas.Real;
        }else if(moedaUtilizada == 2)
        {
            return Moedas.Dolar;
        }else if(moedaUtilizada == 3)
        {
            return Moedas.Euro;
        }else if(moedaUtilizada == 4)
        {
            return Moedas.Iene;
        }else {
            return Moedas.Libra;
        } 
    }
    public static void Inicializar()
    {
        Console.WriteLine("Qual moeda você utilizará");
        var moedaUtilizada = MenuDeMoedas();

        Console.WriteLine("Para qual moeda você irá converter?");
        var moedaParaQualConvertera = MenuDeMoedas();
        
        Console.WriteLine("Digite o valor que você utilizará");
        var valorDigitado = decimal.Parse(Console.ReadLine());
        
        CasosDeConversao(moedaUtilizada, moedaParaQualConvertera, valorDigitado);
    }
}


