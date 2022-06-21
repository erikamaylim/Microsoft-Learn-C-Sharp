class Aula14
{
    static void Main()
    {
        // Converter Fahrenheit em Celsius
        int fahrenheit = 94;
        decimal celsius = (fahrenheit - 32m) * (5m / 9m);
        Console.WriteLine($"A temperatura atual é de {celsius}ºC.");
    }
}