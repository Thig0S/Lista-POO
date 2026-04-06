namespace ex02;

class Converter
{
    public decimal celsius;
    public decimal Fahrenheit;

    public void ConverteTemp(Converter c)
    {
        Fahrenheit = (celsius * 9 / 5) + 32;
    }

}