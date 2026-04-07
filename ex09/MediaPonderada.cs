namespace ex09;

class MediaPonderada
{
    public decimal nota1;
    public decimal nota2;
    public decimal Media;

    public void Calcular(MediaPonderada m)
    {
        m.Media = (m.nota1 * 2 + m.nota2 * 3) / (2 + 3);
        System.Console.WriteLine(m.Media);
    }
}
