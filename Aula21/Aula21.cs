// Inicializar uma matriz
class Aula21
{
    static void Main()
    {
        string [] IDsPedidosFraudulentos = {"A123", "B456", "C789"};
        Console.WriteLine($"Primeiro: {IDsPedidosFraudulentos[0]}");
        Console.WriteLine($"Segundo: {IDsPedidosFraudulentos[1]}");
        Console.WriteLine($"Terceiro: {IDsPedidosFraudulentos[2]}");
        IDsPedidosFraudulentos[0] = "F000";
        Console.WriteLine($"Reatribuir primeiro: {IDsPedidosFraudulentos[0]}");
        Console.WriteLine($"Há {IDsPedidosFraudulentos.Length} pedidos fraudulentos para processar");  // Propriedade Lenght permite descobrir o nº de elementos em uma matriz
    }
}