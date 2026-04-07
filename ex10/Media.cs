class Media
{
    public decimal nota01;
    public decimal nota02;
    public decimal media;

    public void Calcular(Media m)
    {
        m.media = 2 / (1 / nota01 + 1 / nota02);
        System.Console.WriteLine(m.media);
    }

}
