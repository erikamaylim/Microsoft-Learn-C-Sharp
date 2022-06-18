class Aula19
{
    static void Main()
    {
        Random random = new Random();
        int diasAteVencimento = random.Next(12);
        int porcentDesconto = 0;

        if (diasAteVencimento == 0)
        {
            Console.WriteLine("Sua assinatura expirou.");
        }
        else if (diasAteVencimento == 1)
        {
            porcentDesconto = 20;
            Console.WriteLine($"Sua assinatura expirará em 1 dia.");
        }
        else if (diasAteVencimento <= 5)
        {
            porcentDesconto = 10;
            Console.WriteLine($"Sua assinatura expirará em {diasAteVencimento} dias."); 
        }
        else if (diasAteVencimento <= 10)
        {
            Console.WriteLine($"Sua assinatura expirará em {diasAteVencimento} dias. Renove agora!");        
            
        }
        if (porcentDesconto > 0)
        {
            Console.WriteLine($"Renove agora e ganhe {porcentDesconto}% de desconto!");
        }
    }
}