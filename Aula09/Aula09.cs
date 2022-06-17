// Interpolação de cadeia de caracteres: combina vários valores em uma única cadeia de caracteres literal usando um "modelo" e uma ou mais expressões de interpolação (variável cercada por um símbolo de chave de abertura e fechamento { }. A cadeia de caracteres literal se torna um modelo quando ele é prefixado pelo caractere $.)
class Aula09
{
    static void Main()
    {        
        string nome = "Suki";
        string cumprimento = "Olá,";
        string mensagem = $"Olá, {nome}!";
        Console.WriteLine(mensagem);
        Console.WriteLine($"{cumprimento} {nome}!");
        // Combinar literais textuais e interpolação de cadeia de caracteres
        string nomeProjeto = "Primeiro-Projeto";
        Console.WriteLine($@"C:\Output\{nomeProjeto}\Data");
    }
}