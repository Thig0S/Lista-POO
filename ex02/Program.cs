namespace ex02;

class Program
{
    static void Main(string[] args)
    {
        Converter c = new Converter();

        System.Console.Write("Digite a temperatura em Celsius: ");
        c.celsius = Convert.ToDecimal(Console.ReadLine());

        c.ConverteTemp(c);

        System.Console.WriteLine("Conversao para Fahrenheit: " + c.Fahrenheit);
    }
}
