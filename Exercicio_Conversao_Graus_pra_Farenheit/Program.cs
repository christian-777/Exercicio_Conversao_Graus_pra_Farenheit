internal class Program
{
    private static void Main(string[] args)
    {
        //exercicio de conversao de celcius para farenheit

        double temp, converted;

        Console.WriteLine("Digite a temperatura em celcius: ");
        temp = double.Parse(Console.ReadLine());

        converted = (temp * 1.8) + 32;

        Console.WriteLine("celcius: " + temp + "\n" + "farenheit: " + converted);

    }
}