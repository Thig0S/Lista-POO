
internal class Program
{
    private static void Main(string[] args)
    {
        Retangulo retangulo = new Retangulo();

        Console.Write("Digite a altura: ");
        retangulo.Altura = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Digite a largura: ");
        retangulo.Largura = Convert.ToDecimal(Console.ReadLine());

        retangulo.CalcularVolume(retangulo);

        System.Console.WriteLine("Volume: " + retangulo.Volume);
    }
}