namespace ConversorDeMoedas;

/// <summary>
/// Converte valores de Real para moeda estrangeira e vice-versa.
/// </summary>
internal static class Conversor
{
    private const decimal _dolarRatio = 1M / 4.5M;
    private const decimal _euroRatio = 1M / 6.2M;
    private const decimal _ieneRatio = 1M / 0.052M;
    private const decimal _libraRatio = 1M / 6.95M;

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
            Moeda.Dolar => valorMoedaEstrangeira * _dolarRatio,
            Moeda.Euro => valorMoedaEstrangeira * _euroRatio,
            Moeda.Iene => valorMoedaEstrangeira * _ieneRatio,
            Moeda.Libra => valorMoedaEstrangeira * _libraRatio,
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
            Moeda.Dolar => valorEmReal / _dolarRatio,
            Moeda.Euro => valorEmReal / _euroRatio,
            Moeda.Iene => valorEmReal / _ieneRatio,
            Moeda.Libra => valorEmReal / _libraRatio,
            _ => throw new NotImplementedException($"Moeda do tipo {moeda} não foi implementada.")
        };
    }
}
