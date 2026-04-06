namespace ex04;

class Combustivel
{
    public decimal KmInicial;
    public decimal KmFinal;
    public decimal CombustivelGasto;
    public decimal CombustivelGastoNaViagem;
    public void CalcularGasto(Combustivel c)
    {
        decimal diferencaKm = KmFinal - KmInicial;
        CombustivelGastoNaViagem = diferencaKm / CombustivelGasto;
    }
}
