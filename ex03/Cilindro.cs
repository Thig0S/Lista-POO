namespace ex03;

class Cilindro
{
    public decimal Altura;
    public decimal Raio;
    public const decimal PI = 3.14m;

    public decimal Volume;

    public void CalcularVolume(Cilindro c)
    {
        c.Volume = PI* c.Altura * c.Altura * c.Raio;
    }

}
