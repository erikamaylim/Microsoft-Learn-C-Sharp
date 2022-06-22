// Expressões boolianas
class Aula01
{
    static void Main()
    {
        Console.WriteLine($"a = a: {"a" == "a"}");
        Console.WriteLine($"a = a : {"a" == "a "}");
        Console.WriteLine($"a != b: {"a" != "b"}");
        Console.WriteLine($"1 < 2: {1 < 2}");
        Console.WriteLine($"1 > 2: {1 > 2}");
        Console.WriteLine($"1 <= 2: {1 <= 2}");
        Console.WriteLine($"1 >= 2: {1 >= 2}");

        Console.WriteLine($"a = A: {"a" == "A"}");
        Console.WriteLine($"1 = 2: {1 == 2}");

        string letra = "a";
        Console.WriteLine($"{letra == "a"}");

        // Moldar dados
        string letra1 = " a";
        string letra2 = "A ";
        Console.WriteLine(letra1.Trim().ToLower() == letra2.Trim().ToLower());
        Console.WriteLine(letra1.Trim().ToUpper() == letra2.Trim().ToUpper()); 
    }
}