namespace ex04;

class Program
{
    static void Main(string[] args)
    {
        Combustivel c = new Combustivel();

        System.Console.Write("Digite a quilometragem inicial do veiculo: ");
        c.KmInicial = Convert.ToDecimal(Console.ReadLine());

        System.Console.Write("Digite a quilometragem final do veiculo: ");
        c.KmFinal = Convert.ToDecimal(Console.ReadLine());

        System.Console.Write("Digite a quantidade de combustivel utilizada pelo veiculo: ");
        c.CombustivelGasto = Convert.ToDecimal(Console.ReadLine());

        c.CalcularGasto(c);

        System.Console.WriteLine("Foi consumido : " + c.CombustivelGastoNaViagem);
    }
}
