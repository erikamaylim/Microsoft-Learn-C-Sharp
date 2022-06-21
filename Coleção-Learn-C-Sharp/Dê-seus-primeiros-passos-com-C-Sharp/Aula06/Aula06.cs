// Sequências de escape de caractere
class Aula06
{
    static void Main()
    {        
        Console.WriteLine("Olá,\nMundo!");   // \n adiciona nova linha
        Console.WriteLine("Olá,\tMundo!"); // \t adiciona espaço; tab
        // Inserir aspas duplas em cadeia de caracteres literal
        Console.WriteLine("Olá, \"Mundo\"!\n\n");
        // Usar barra invertida para outras finalidades, como exibir o caminho de um arquivo
        Console.WriteLine("c:\\source\\repositórios");
        // Formatar a saída do aplicativo de linha de comando usando sequências de escape de caractere
        Console.WriteLine("Gerando faturas para cliente \"ABC Corp\" ...\n");
        Console.WriteLine("Fatura: 1021\t\tCompleta!");
        Console.WriteLine("Fatura: 1022\t\tCompleta!");
        Console.WriteLine("\nDiretório de Saída:\t");
        // Literal de cadeia de caracteres textual
        Console.WriteLine(@"   c:\source\repositórios   
        (é aqui que seu código vai)");  // Mantem todo o espaço em branco e os caracteres sem a necessidade da barra invertida. Para criar uma cadeia de caracteres textual, use a diretiva @ antes da cadeia de caracteres literal.
        // Formatar a saída do aplicativo de linha de comando usando uma cadeia de caracteres textual
        Console.Write(@"c:\faturas");
    }
}