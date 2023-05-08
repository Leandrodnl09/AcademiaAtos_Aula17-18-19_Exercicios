namespace AcademiaAtos_Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 - Crie uma classe chamada Livro que tenha as propriedades Titulo e Autor (outra classe). Utilize o encapsulamento 
            // para garantir que o título e o autor não sejam vazios.

            List<Livro> livros = new List<Livro>();

            while (true)
            {
                Console.WriteLine("Digite o título do livro (0 para sair):");
                string titulo = Console.ReadLine();

                if (titulo == "0")
                    break;

                Console.WriteLine("Digite o nome do autor do livro:");
                string nomeAutor = Console.ReadLine();

                Autor autor = new Autor(nomeAutor);
                Livro livro = new Livro(titulo, autor);
                livros.Add(livro);

                Console.WriteLine($"Livro '{titulo}' cadastrado com sucesso!");
                Console.WriteLine();
            }

            Console.WriteLine("Lista de livros cadastrados:");

            foreach (Livro livro in livros)
            {
                Console.WriteLine($"Título: {livro.Titulo}");
                Console.WriteLine($"Autor: {livro.Autor.Nome}");
                Console.WriteLine();
            }
        }
    }
}