class Aula23
{
    static void Main()
    {
        string[] IDsPedidosFraudulentos = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};
        foreach (string item in IDsPedidosFraudulentos)
        {
            if (item.StartsWith("B"))
            {
                Console.WriteLine(item);
            }
    
        }
    }
}