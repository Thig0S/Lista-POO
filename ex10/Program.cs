
internal class Program
{


    private static void Main(string[] args)
    {
        Media m = new Media();

        System.Console.WriteLine("Digite a nota 1: ");
        m.nota01 = Convert.ToDecimal(Console.ReadLine());

        System.Console.WriteLine("Digite a nota 2: ");
        m.nota02 = Convert.ToDecimal(Console.ReadLine());

        m.Calcular(m);
    }
}