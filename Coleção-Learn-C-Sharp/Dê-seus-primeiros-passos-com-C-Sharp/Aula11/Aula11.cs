class Aula11
{
    static void Main()
    {
        // Adição de dois valores numéricos
        int n1 = 12;
        int n2 = 7;
        Console.WriteLine(n1 + n2);
        // Misturar tipos de dados para forçar as conversões de tipo implícitas
        string nome = "Paulo";
        int vendas = 7;
        Console.WriteLine(nome + " vendeu " + vendas + " peças.");
        // Tentar um caso mais avançado de adição de números e concatenação de cadeias de caracteres
        Console.WriteLine(nome + " vendeu " + vendas + 7 + " peças."); // acrescenta o 7 após o valor da int vendas
        // adicionar parênteses para deixar nossa intenção clara para o compilador
        Console.WriteLine(nome + " vendeu " + (vendas + 7) + " peças."); // soma valor da int vendas com o 7 
    }
}