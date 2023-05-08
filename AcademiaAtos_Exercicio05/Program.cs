namespace AcademiaAtos_Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10 - Crie uma classe chamada Animal que tenha as propriedades Nome, Especie e Idade. Crie também um método chamado
            // EmitirSom, que imprime na tela o som do animal.

            Console.Write("Digite o nome do animal: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o tipo do animal: ");
            string especie = Console.ReadLine().ToLower();

            Console.Write("Digite a idade do animal: ");
            int idade = int.Parse(Console.ReadLine());

            Animal meuAnimal = new Animal();
            meuAnimal.Nome = nome;
            meuAnimal.Especie = especie;
            meuAnimal.Idade = idade;

            meuAnimal.EmitirSom();

            Console.ReadKey();
        }
    }
}