namespace AcademiaAtos_Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crie uma classe chamada Aluno que tenha as propriedades Nome e Matricula. Utilize o encapsulamento para garantir 
            // que o nome não seja vazio(utilize função nativa) e que a matrícula seja positiva.


            List<Aluno> alunos = new List<Aluno>();

            while (true)
            {
                Console.WriteLine("Digite o nome do aluno (ou 0 para sair):");
                string nome = Console.ReadLine();

                if (nome == "0")
                {
                    break;
                }

                Console.WriteLine("Digite a matrícula do aluno:");
                int matricula = int.Parse(Console.ReadLine());

                try
                {
                    Aluno aluno = new Aluno();
                    aluno.Nome = nome;
                    aluno.Matricula = matricula;

                    alunos.Add(aluno);
                    Console.WriteLine("Aluno cadastrado com sucesso!");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Erro ao cadastrar aluno: " + ex.Message);
                }
            }

            Console.WriteLine("Lista de alunos cadastrados:");
            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine("Nome: " + aluno.Nome + ", Matrícula: " + aluno.Matricula);
            }

        }
    }
}