namespace ex09;

class Program
{
    static void Main(string[] args)
    {
        MediaPonderada m = new MediaPonderada();

        System.Console.WriteLine("Digite a nota 1: ");
        m.nota1 = Convert.ToDecimal(Console.ReadLine());

        System.Console.WriteLine("Digite a nota 2: ");
        m.nota2 = Convert.ToDecimal(Console.ReadLine());

        m.Calcular(m);
    }
}
