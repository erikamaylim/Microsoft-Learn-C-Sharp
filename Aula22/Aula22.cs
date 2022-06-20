// Executar loop em matriz usando instrução foreach (realiza um loop em cada elemento da matriz, executando o bloco de código abaixo da declaração e substituindo o valor em uma variável temporária pelo valor da matriz representada pelo loop atual)
class Aula22
{
    static void Main()
    {
        string[] nomes = {"Carlos", "Lau", "Patricia", "Hugo"};
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }
        Console.WriteLine();

        int[] inventario = {200, 450, 700, 175, 250};  
        int soma = 0;                 // Adicionar variável para somar os elementos da matriz
        int compartimento = 0;        // Criar variável para armazenar o número do compartimento atual e exibir o total atual
        foreach (int itens in inventario)          
        {
            
            soma += itens;
            compartimento++;
            Console.WriteLine($"Compartimento {compartimento} = {itens} items (Total em execução: {soma})");
        }
        Console.WriteLine($"\nHá {soma} itens no inventário\n");

        

    }
}