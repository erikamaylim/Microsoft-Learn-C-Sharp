// Desafio: Restringir acesso a usuários com base nas respectivas permissões e nível. Exibir na tela uma mensagem diferente para cada usuário.
class Aula05
{
    static void Main()
    {
        string permissao = "Admin";
        int nivel = 60;
        if (permissao.Contains("Admin"))        
        {
            if (nivel > 55)
            {
                Console.WriteLine("Bem-vindo, usuário Super Admin");
            }
            else
            {
                Console.WriteLine("Bem-vindo, usuário Admin");
            }
        }
        else if (permissao.Contains("Manager"))        
        {
            if (nivel >= 20)
            {
                Console.WriteLine("Entre em contato com um administrador para ter acesso.");
            }
            else
            {
                Console.WriteLine("Você não tem privilégios suficientes para ter acesso.");
            }
            
        }
        else 
        {
            Console.WriteLine("Acesso negado.");
        }
    }
}