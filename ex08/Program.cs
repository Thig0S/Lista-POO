namespace ex08;

class Program
{
    static void Main(string[] args)
    {
        LataDeOleo lata = new LataDeOleo();

        Console.Write("Digite a Altura do Cilindro");
        lata.Altura = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Digite o raio do Cilindro");
        lata.Raio = Convert.ToDecimal(Console.ReadLine());

        lata.CalcularVolume(lata);
        System.Console.WriteLine("Volume é: " + lata.Volume);
    }
}
