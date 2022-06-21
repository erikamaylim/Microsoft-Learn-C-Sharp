// Matrizes: sequência de elementos de dados individuais que pode ser acessada por meio de um único nome de variável. Matrizes permitem coletar dados semelhantes com uma finalidade ou características em comum em uma única estrutura de dados para facilitar o processamento.
class Aula20
{
    static void Main()
    {
        // Declarar uma nova matriz
        string[] IDsPedidosFraudulentos = new string[3];  // * 
        IDsPedidosFraudulentos[0] = "A123";
        IDsPedidosFraudulentos[1] = "B456";
        IDsPedidosFraudulentos[2] = "C789";
        Console.WriteLine($"Primeiro: {IDsPedidosFraudulentos[0]}");
        Console.WriteLine($"Segundo: {IDsPedidosFraudulentos[1]}");
        Console.WriteLine($"Terceiro: {IDsPedidosFraudulentos[2]}");
        IDsPedidosFraudulentos[0] = "F000";
        Console.WriteLine($"Reatribuir primeiro: {IDsPedidosFraudulentos[0]}");
    }
}

// * Operador new cria instância de uma matriz na memória do computador que pode conter 3 valores de cadeia de caracteres. O primeiro conjunto de colchetes sinaliza a criação de uma matriz. O segundo contém o número de elementos da matriz