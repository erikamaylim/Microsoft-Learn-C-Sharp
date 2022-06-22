// Blocos de código afetam o escopo de uma declaração de variáveis. Escopo de variável é a visibilidade da variável para outro código
class Aula06
{
    static void Main()
    {
        bool flag = true;
        int n1 = 0;

        if (flag)
        {
            n1 = 2;
            Console.WriteLine($"n1 dentro do bloco de código: {n1}");
            int n2 = 10;
            Console.WriteLine($"n2 dentro do bloco de código: {n2}");
        }

        Console.WriteLine($"n1 fora do bloco de código: {n1}");
        Console.WriteLine($"n2 fora do bloco de código: {n2}");   // gera mensagem de erro

    }
}