


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
        //Permite que o usuário digite outros caracteres inválidos e retorne o menu para continuar
        Console.Write(">");
        var sucesso = int.TryParse(Console.ReadLine(), out tipoDeMoeda);
        while (tipoDeMoeda <= 0 || tipoDeMoeda > 5)
        {
            Console.WriteLine("Digite um valor válido");
            tipoDeMoeda = MenuDeMoedas();
        }
        Console.WriteLine("Você selecionou: " + (Moeda)tipoDeMoeda);
        return tipoDeMoeda;
    }

    public static void CasosDeConversao(int moedaUtilizada, int moedaParaQualConvertera, decimal valor)
    {
        if (moedaParaQualConvertera == 1)
        {
            Console.WriteLine($"O valor convertido é {Conversor.ToReal((Moeda)moedaUtilizada, valor)}");
        }
        else
        {
            Console.WriteLine(Conversor.ToMoeda((Moeda)moedaParaQualConvertera, Conversor.ToReal(((Moeda)moedaUtilizada), valor)));
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


