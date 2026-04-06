class Retangulo
{
    public decimal Altura;
    public decimal Largura;
    public decimal Volume;

    public void CalcularVolume(Retangulo r)
    {
        r.Volume = r.Altura * r.Largura;
    }
}
