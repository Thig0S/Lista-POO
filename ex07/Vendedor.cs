namespace ex07;

class Vendedor
{
    public decimal SalarioBase;
    public decimal Vendas;
    public decimal SalarioFinal;

    public void CalcularSalario(Vendedor v, decimal porcentagem)
    {
        v.SalarioFinal = v.SalarioBase + (v.Vendas * porcentagem);
        System.Console.WriteLine($"Salario final de R${v.SalarioFinal}");
    }
}
