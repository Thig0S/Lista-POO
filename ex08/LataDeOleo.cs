namespace ex08;

class LataDeOleo
{
    public decimal Altura;
    public decimal Raio;
    public const decimal PI = 3.14m;

    public decimal Volume;

    public LataDeOleo()
    {
    }

    public void CalcularVolume(LataDeOleo c)
    {
        c.Volume = PI * c.Altura * c.Altura * c.Raio;
    }

}
