class Aula12
{
    static void Main()
    {
        // Escrever código para executar adição, subtração, multiplicação e divisão com ints.
        int soma = 7 + 5;
        int sub = 7 - 5;
        int mult = 7 * 5;
        int div = 7 / 5;
        Console.WriteLine($@"Soma: {soma}
Subtração: {sub}
Multiplicação: {mult}
Divisão: {div}");
        // Adicionar código para executar a divisão usando dados decimais literais.
        decimal divDecimal = 7.0m / 5;    // pelo menos um dos nnumeros deve ser tipo decimal
        Console.WriteLine("Divisão decimal: " + divDecimal);
        // Converter int em decimal
        int n1 = 7;
        int n2 = 5;
        decimal divDec = n1 / (decimal)n2;
        Console.WriteLine("Valor da divisão após conversão: " + divDec);
        // Resto da divisão
        Console.WriteLine($"Resto da divisão {n1} / {n2} é igual a {n1 % n2}");
        Console.WriteLine("Resto da divisão 200 / 5 é igual a " + 200 % 5);
        // Ordem de operações: PEMDAS (Parênteses; Expoentes; Multiplicação e Divisão; Adição e Subtração)
        // C# segue a mesma ordem que o acrônimo PEMDAS, exceto pelos exponentes. Embora não haja um operador com exponente em C#, você pode usar o método System.Math.Pow(), que está disponível na Biblioteca de Classes .NET.
        int n3 = 3 + 4 * 5;
        int n4 = (3 + 4) * 5;
        Console.WriteLine(n3);
        Console.WriteLine(n4);
    }
}