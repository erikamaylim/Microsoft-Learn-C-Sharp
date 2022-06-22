// Operador condicional ternário
// < avalie esta condição > ? < se condição for verdadeira, retorne este valor> : < se condição for falsa, retorne este valor>
class Aula03
{
    static void Main()
    {
        int valorVenda = 1001;
        int desconto = valorVenda > 1000 ? 100 : 50;
        Console.WriteLine($"Valor do desconto: {desconto}");
        // Outra forma, sem necessidade de criar a variável "desconto"
        Console.WriteLine($"Valor do desconto: {(valorVenda > 1000 ? 100 : 50)}");
    }
}