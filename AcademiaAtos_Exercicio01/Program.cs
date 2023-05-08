using System.Runtime.Intrinsics.X86;

namespace AcademiaAtos_Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa em c# orientada a objeto para Uma unidade de saúde, ao receber pessoas para consultas, realizar cadastro do paciente (nome, cpf, data de nascimento, email).
            // Feito isso, o paciente cadastrado o parciente participa de uma triagem. (valida os dados do paciente,
            // peso, altura, pressão arterial e temperatura). Em cima desses dados técnico ou infermeiro colocam  urgência de atendimento(verde, amarelo e vermelho).
            // Feito isso, o paciente é chamato a consulta, em que são guardados. 
            //  paciente
            //  triagem
            //  nome e crm do médico
            //  prescrição gerada

            // Lista para armazenar os pacientes cadastrados
            List<Paciente> pacientes = new List<Paciente>();

            // Loop para permitir que o usuário cadastre vários pacientes
            bool cadastrarOutroPaciente = true;
            while (cadastrarOutroPaciente)
            {
                Console.WriteLine("Cadastro de Paciente");
                Console.WriteLine("====================");

                // Solicita ao usuário para inserir os dados do paciente
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("CPF: ");
                string cpf = Console.ReadLine();

                Console.Write("Data de Nascimento (dd/mm/aaaa): ");
                string dataNascimento = Console.ReadLine();

                Console.Write("E-mail: ");
                string email = Console.ReadLine();

                // Cria uma instância de Paciente com os dados informados pelo usuário
                Paciente paciente = new Paciente(nome, cpf, dataNascimento, email);

                // Realiza a triagem do paciente
                paciente.RealizarTriagem();

                // Adiciona o paciente à lista de pacientes cadastrados
                pacientes.Add(paciente);

                // Pergunta ao usuário se deseja cadastrar outro paciente
                Console.Write("Deseja cadastrar outro paciente? (S/N): ");
                string resposta = Console.ReadLine();
                cadastrarOutroPaciente = (resposta.ToLower() == "s");
            }

            // Exibe a lista de pacientes cadastrados
            Console.WriteLine();
            Console.WriteLine("Lista de Pacientes Cadastrados");
            Console.WriteLine("=============================");
            foreach (Paciente paciente in pacientes)
            {
                paciente.ImprimirDados();
            }

            Console.ReadKey();
        }
    }
}