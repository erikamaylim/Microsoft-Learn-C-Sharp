// Variável do tipo implícito: é criada usando a palavra-chave var, que instrui o compilador de C# a inferir o tipo.
// Em C#, a variável é tipada estaticamente pelo compilador. O tipo é bloqueado no momento da declaração e, portanto, nunca poderá conter valores de um tipo de dados diferente.
// Só é possível usar a palavra-chave var se a variável for inicializada.
class Aula05
{
    static void Main()
    {        
        var mensagem = "Olá, mundo";
        Console.WriteLine(mensagem);
    }
}
