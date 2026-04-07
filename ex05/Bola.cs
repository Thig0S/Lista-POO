namespace ex05;

class Bola
{
    public double Raio;
    public const double PI = 3.14;
    public double Volume;

    public void CalcularVolume(Bola b)
    {
        b.Volume = (4.0 / 3.0) * Math.PI * Math.Pow(b.Raio, 3);
        System.Console.WriteLine($"O volume é: " + b.Volume);
    }
}
