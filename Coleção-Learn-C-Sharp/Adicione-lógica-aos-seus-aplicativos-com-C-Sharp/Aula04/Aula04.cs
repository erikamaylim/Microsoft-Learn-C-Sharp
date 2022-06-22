// Desafio: Lançar uma moeda e exibir resultado cara ou coroa
class Aula04
{
    static void Main()
    {
        Random moeda = new Random();           
        Console.WriteLine((moeda.Next(2) == 0) ? "cara" : "coroa");
    }
}