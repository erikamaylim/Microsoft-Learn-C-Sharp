// Métodos que retornam um valor booliano
class Aula02
{
    static void Main()
    {
        string pangrama = "Veja na Web o extravagante salto da raposa sobre o cachorro Yorkshire que dorme feliz";
        Console.WriteLine(pangrama.Contains("raposa"));
        Console.WriteLine(pangrama.Contains("FELIZ"));
        // As duas linhas abaixo fazem a mesma coisa
        Console.WriteLine(pangrama.Contains("raposa") == false);
        Console.WriteLine(!pangrama.Contains("raposa"));

        Console.WriteLine(pangrama.StartsWith("V"));
        Console.WriteLine(pangrama.EndsWith("z"));
    }
}