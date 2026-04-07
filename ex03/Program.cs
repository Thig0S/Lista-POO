namespace ex08;

class Program
{
    static void Main(string[] args)
    {
        Cilindro cilindro = new Cilindro();

        Console.Write("Digite a Altura do Cilindro");
        cilindro.Altura = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Digite o raio do Cilindro");
        cilindro.Raio = Convert.ToDecimal(Console.ReadLine());

        cilindro.CalcularVolume(cilindro);
        System.Console.WriteLine("Volume é: " + cilindro.Volume);
    }
}
