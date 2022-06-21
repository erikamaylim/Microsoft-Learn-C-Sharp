class Aula13
{
    static void Main()
    {
        // Incrementar e decrementar valores
        int n = 0;
        Console.WriteLine("Valor inicial de n -> " + n);
        n = n + 5;
        Console.WriteLine("n = n + 5 -> " + n);
        n += 5;
        Console.WriteLine("n += 5 -> " + n);
        n++;
        Console.WriteLine("n++ -> " + n);
        n = n - 5;
        Console.WriteLine("n = n - 5 -> " + n);
        n -= 5;
        Console.WriteLine("n -= 5 -> " + n);
        n--;
        Console.WriteLine("n-- -> " + n);
        // Posicionando os operadores de incremento e decremento
        int n2 = 1;
        n2++;
        Console.WriteLine("1ª: " + n2);
        Console.WriteLine("2ª: " + n2++);  // Exibe valor de n2 e depois faz o incremento
        Console.WriteLine("3ª: " + n2);
        Console.WriteLine("4ª: " + (++n2));  // Incrementa e depois exibe valor de n2 incrementado
    }
}