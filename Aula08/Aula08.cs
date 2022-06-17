class Aula08
{
    static void Main()
    {
        // Concatenar uma cadeia de caracteres literal e uma variável.
        string nome = "Suki";
        string mensagem = "Olá, " + nome;
        Console.WriteLine(mensagem);

        // Concatenar diversas variáveis e cadeias de caracteres literais.
        string cumprimento2 = "Olá,";
        string mensagem2 = cumprimento2 + " " + nome + "!";
        Console.WriteLine(mensagem2);
        // Evite variáveis intermediárias
        Console.WriteLine(cumprimento2 + " " + nome + "!");
    }
}