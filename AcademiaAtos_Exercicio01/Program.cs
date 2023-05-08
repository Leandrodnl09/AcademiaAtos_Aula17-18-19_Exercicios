namespace AcademiaAtos_Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - Crie classes chamadas Fabricante e Produto. Fabricante que tenha as propriedades Nome, Endereço e Cidade. 
            // Produto que tenha as propriedades Nome, Fabricante e Preco.Utilize o encapsulamento para garantir que o nome não
            // seja vazio e que o preço seja positivo.

            List<Produto> produtos = new List<Produto>();

            Console.WriteLine("Cadastro de produtos");
            Console.WriteLine("Digite 0 para sair");
            Console.WriteLine();

            while (true)
            {
                Console.Write("Nome do produto: ");
                string nome = Console.ReadLine();

                if (nome == "0")
                {
                    break;
                }

                Produto produto = new Produto();
                produto.Nome = nome;

                Console.Write("Preço do produto: ");
                string precoStr = Console.ReadLine();

                if (precoStr == "0")
                {
                    break;
                }

                double preco;

                if (!double.TryParse(precoStr, out preco) || preco <= 0)
                {
                    Console.WriteLine("Preço inválido");
                    continue;
                }

                produto.Preco = preco;

                Fabricante fabricante = new Fabricante();

                Console.Write("Nome do fabricante: ");
                fabricante.Nome = Console.ReadLine();

                Console.Write("Endereço do fabricante: ");
                fabricante.Endereco = Console.ReadLine();

                Console.Write("Cidade do fabricante: ");
                fabricante.Cidade = Console.ReadLine();

                produto.Fabricante = fabricante;

                produtos.Add(produto);

                Console.WriteLine("Produto cadastrado com sucesso");
                Console.WriteLine();
            }

            Console.WriteLine("Lista de produtos cadastrados:");
            Console.WriteLine();
            
            foreach (Produto produto in produtos)
            {
                Console.WriteLine($"Nome: {produto.Nome}");
                Console.WriteLine($"Preço: {produto.Preco:C}");
                Console.WriteLine($"Fabricante: {produto.Fabricante.Nome}");
                Console.WriteLine($"Endereço: {produto.Fabricante.Endereco}");
                Console.WriteLine($"Cidade: {produto.Fabricante.Cidade}");
                Console.WriteLine();
            }
        }
    }
}