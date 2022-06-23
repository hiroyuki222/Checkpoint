namespace ConversorDeMoedas;

internal static class Conversor
{
    private const decimal _realToDolar = 4.5M;
    private const decimal _realToEuro = 6.2M;
    private const decimal _realToIene = 0.052M;
    private const decimal _realToLibra = 6.95M;

    private const decimal _dolarToReal = 1M / _realToDolar;
    private const decimal _euroToReal = 1M / _realToEuro;
    private const decimal _ieneToReal = 1M / _realToIene;
    private const decimal _libraToReal = 1M / _realToLibra;

    public static decimal ToReal(Moedas moeda, decimal valor)
    {
        return moeda switch
        {
            Moedas.Real => valor,
            Moedas.Dolar => valor * _dolarToReal,
            Moedas.Euro => valor * _euroToReal,
            Moedas.Iene => valor * _ieneToReal,
            Moedas.Libra => valor * _libraToReal,
            _ => throw new NotImplementedException()
        };
    }

    public static decimal ToMoeda(Moedas moeda, decimal valorEmReal)
    {
        return moeda switch
        {
            Moedas.Real => valorEmReal,
            Moedas.Dolar => valorEmReal * _realToDolar,
            Moedas.Euro => valorEmReal * _realToEuro,
            Moedas.Iene => valorEmReal * _realToIene,
            Moedas.Libra => valorEmReal * _realToLibra,
            _ => throw new NotImplementedException()
        };
    }
}
