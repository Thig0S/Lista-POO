namespace ex05;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o raio da bola");
        Bola b = new Bola();
        b.Raio = Convert.ToDouble(Console.ReadLine());

        b.CalcularVolume(b);
    }
}
