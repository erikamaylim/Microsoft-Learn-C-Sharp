// Biblioteca de Classes: coleção de classes que contém diversos métodos.
// Uma classe é um contêiner para métodos relacionados.
// Namespace é como um "nome de família", onde agrupa as classes por tipos. Classes são organizadas em namespaces para evitar colisões de nomenclatura.
/* Chamar métodos na Biblioteca de Classes do .NET:
    - Comece digitando o nome de classe, Console
    - Adicione o operador de acesso de membro, o símbolo .
    - Adicione o nome do método, WriteLine
    - Adicione o operador de chamada do método, que é um conjunto de parênteses ()
    - Por fim, adicione o valor que você deseja que o método Console.WriteLine() imprima como um parâmetro de entrada entre os parênteses de abertura e fechamento */
    /* 
        - Exemplo de código:
                Random dice = new Random();
                int roll = dice.Next(1, 7);
                Console.WriteLine(roll); 
            - A primeira linha de código 
            */
class Aula15
{
    static void Main()
    {
        // Chamar diferentes tipos de métodos na Biblioteca de Classes do .NET:
        Random dado = new Random(); // cria uma instância da classe (objeto) System.Random na Biblioteca de Classes do .NET e armazena a referência ao novo objeto em uma variável denominada dado.
        int jogar = dado.Next(1, 7); // chama o método Next() do objeto dice que passa dois parâmetros: o valor mínimo e o máximo do número aleatório. O método Next() retorna o valor, que salvamos em uma variável chamada jogar.
        Console.WriteLine(jogar); 
    }
}

// Para criar uma instância de classe (objeto), usa-se o operador new
// Método sem estado (estático): Não depende do estado atual do aplicativo para funcionar. Funciona sem referenciar ou alterar valores já armazenados na memória.
// Método com estado (de instância): Depende de valores armazenados na memória pelas linhas de código anteriores que foram executadas.