namespace ex07;

class Program
{
    static void Main(string[] args)
    {
        Vendedor v = new Vendedor();
        Console.WriteLine("Digite o Salario Base do Vendedor: ");
        v.SalarioBase = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Digite as vendas do Vendedor: ");
        v.Vendas = Convert.ToDecimal(Console.ReadLine());

        System.Console.WriteLine("Digite a porcentagem de comissao EX: 0.10");
        decimal porcentagem = Convert.ToDecimal(Console.ReadLine());

        v.CalcularSalario(v, porcentagem);
    }
}
