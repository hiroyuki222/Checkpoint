


namespace ConversorDeMoedas;
internal static class Menu
{

    public static int MenuDeMoedas()
    {
        var tipoDeMoeda = 0;
        Console.WriteLine(
                "1 - Real\n" +
                "2 - Dolar\n" +
                "3 - Euro\n" +
                "4 - Iene\n" +
                "5 - Libra");
        tipoDeMoeda = int.Parse(Console.ReadLine());
        while (tipoDeMoeda <= 0 || tipoDeMoeda > 5)
        {
            Console.WriteLine("Digite um valor válido");
            tipoDeMoeda = MenuDeMoedas();
        }
            return tipoDeMoeda;
    }
   
    public static void CasosDeConversao(int moedaUtilizada, int moedaParaQualConvertera, decimal valor)
    {
        if(moedaParaQualConvertera == 1)
        {
            Console.WriteLine($"O valor convertido é {Conversor.ToReal(TipoDeMoeda(moedaUtilizada),valor)}");
        }
        else
        {
            Console.WriteLine(Conversor.ToMoeda(TipoDeMoeda(moedaParaQualConvertera), Conversor.ToReal(TipoDeMoeda(moedaUtilizada),valor)));
        }
        
    }
    //<summary>
    //Retorna o tipo da moeda
    //<summary>
    public static Moeda TipoDeMoeda(int moedaUtilizada)
    {
        if(moedaUtilizada == 1)
        {
            return Moeda.Real;
        }else if(moedaUtilizada == 2)
        {
            return Moeda.Dolar;
        }else if(moedaUtilizada == 3)
        {
            return Moeda.Euro;
        }else if(moedaUtilizada == 4)
        {
            return Moeda.Iene;
        }else {
            return Moeda.Libra;
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


