namespace ConversorDeMoedas;

/// <summary>
/// Converte valores de Real para moeda estrangeira e vice-versa.
/// </summary>
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

    /// <summary>
    /// Converte valor de moeda estrangeira para Real.
    /// </summary>
    /// <param name="moeda">A moeda estrangeira desejada.</param>
    /// <param name="valorMoedaEstrangeira">O valor da moeda estrangeira.</param>
    /// <returns>O valor da moeda estrangeira, convertido para Real.</returns>
    /// <exception cref="NotImplementedException">Ocorre quando moeda não possui implementação</exception>
    public static decimal ToReal(Moeda moeda, decimal valorMoedaEstrangeira)
    {
        return moeda switch
        {
            Moeda.Real => valorMoedaEstrangeira,
            Moeda.Dolar => valorMoedaEstrangeira * _dolarToReal,
            Moeda.Euro => valorMoedaEstrangeira * _euroToReal,
            Moeda.Iene => valorMoedaEstrangeira * _ieneToReal,
            Moeda.Libra => valorMoedaEstrangeira * _libraToReal,
            _ => throw new NotImplementedException($"Moeda do tipo {moeda} não foi implementada.")
        };
    }

    /// <summary>
    /// Converte valor de Real para moeda estrangeira.
    /// </summary>
    /// <param name="moeda">A moeda estrangeira desejada.</param>
    /// <param name="valorEmReal">O valor a ser convertido, em Real.</param>
    /// <returns>O valor em Real, convertido para moeda estrangeira.</returns>
    /// <exception cref="NotImplementedException">Ocorre quando moeda não possui implementação</exception>
    public static decimal ToMoeda(Moeda moeda, decimal valorEmReal)
    {
        return moeda switch
        {
            Moeda.Real => valorEmReal,
            Moeda.Dolar => valorEmReal * _realToDolar,
            Moeda.Euro => valorEmReal * _realToEuro,
            Moeda.Iene => valorEmReal * _realToIene,
            Moeda.Libra => valorEmReal * _realToLibra,
            _ => throw new NotImplementedException($"Moeda do tipo {moeda} não foi implementada.")
        };
    }
}
