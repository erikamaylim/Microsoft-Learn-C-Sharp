class Aula17
{
    static void Main()
    {
        Random dado = new Random();
        
        int jogada1 = dado.Next(1, 7);
        int jogada2 = dado.Next(1, 7);
        int jogada3 = dado.Next(1, 7);
        int soma = jogada1 + jogada2 + jogada3;
        Console.WriteLine($@"Primeira jogada: {jogada1}
Segunda jogada: {jogada2}
Terceira jogada: {jogada3}");

        if (jogada1 == jogada2 || jogada1 == jogada3 || jogada2 == jogada3)
        {
            if ((jogada1 == jogada2) && (jogada2 == jogada3))
            {
                Console.WriteLine("\nVocê tirou três números iguais! Ganhou 6 pontos extras!");
                soma += 6;
            }
            else
            {
                Console.WriteLine("\nVocê tirou dois números iguais! Ganhou 2 pontos extras!");
            soma += 2;

            }
        }
        
        if (soma >= 15)
        {
            Console.WriteLine($"\n{soma}. Você ganhou!");
        }
        else
        {
            Console.WriteLine($"\n{soma}. Você perdeu. :(");
        }
    }
}