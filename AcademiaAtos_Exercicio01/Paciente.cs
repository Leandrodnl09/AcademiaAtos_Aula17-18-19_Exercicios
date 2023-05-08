using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio01
{
    internal class Paciente
    {
        public Paciente(string? nome, string? cpf, string? dataNascimento, string? email)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
        }

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double PressaoArterial { get; set; }
        public double Temperatura { get; set; }
        public string UrgenciaAtendimento { get; set; }
        public string NomeMedico { get; set; }
        public string CrmMedico { get; set; }
        public string PrescricaoMedica { get; set; }



        public void CadastrarPaciente()
        {
            Console.WriteLine("Cadastro do Paciente:");
            Console.Write("Nome: ");
            Nome = Console.ReadLine();
            Console.Write("CPF: ");
            Cpf = Console.ReadLine();
            Console.Write("Data de Nascimento (dd/mm/aaaa): ");
            DataNascimento = DateTime.Parse(Console.ReadLine());
            Console.Write("Email: ");
            Email = Console.ReadLine();
            Console.WriteLine("Paciente cadastrado com sucesso!");
            Console.WriteLine();
        }

        public void RealizarTriagem()
        {
            Console.WriteLine("Triagem:");
            Console.Write("Peso (em kg): ");
            Peso = double.Parse(Console.ReadLine());
            Console.Write("Altura (em metros): ");
            Altura = double.Parse(Console.ReadLine());
            Console.Write("Pressão Arterial: ");
            PressaoArterial = double.Parse(Console.ReadLine());
            Console.Write("Temperatura (em graus Celsius): ");
            Temperatura = double.Parse(Console.ReadLine());

            if (Peso <= 0 || Altura <= 0 || PressaoArterial <= 0 || Temperatura <= 0)
            {
                Console.WriteLine("Erro: Dados inválidos!");
                RealizarTriagem();
                return;
            }

            if (Temperatura >= 39 || PressaoArterial >= 14)
            {
                UrgenciaAtendimento = "vermelho";
            }
            else if (Temperatura >= 38 || PressaoArterial >= 12)
            {
                UrgenciaAtendimento = "amarelo";
            }
            else
            {
                UrgenciaAtendimento = "verde";
            }

            Console.WriteLine("Triagem realizada com sucesso!");
            Console.WriteLine("Urgência de atendimento: " + UrgenciaAtendimento);
            Console.WriteLine();
        }


        public void IrConsulta()
        {
            Console.WriteLine("Consulta:");
            Console.Write("Nome do Médico: ");
            NomeMedico = Console.ReadLine();
            Console.Write("CRM do Médico: ");
            CrmMedico = Console.ReadLine();
            Console.Write("Prescrição Médica: ");
            PrescricaoMedica = Console.ReadLine();

            Console.WriteLine("Consulta realizada com sucesso!");
            Console.WriteLine();
            Console.WriteLine("Dados do Paciente:");
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("CPF: " + Cpf);
            Console.WriteLine("Data de Nascimento: " + DataNascimento.ToString("dd/MM/yyyy"));
            Console.WriteLine("Email: " + Email);
            Console.WriteLine();
            Console.WriteLine("Dados da Triagem: ");
            Console.WriteLine("Peso: " + Peso.ToString("F2") + " kg ");
            Console.WriteLine("Altura: " + Altura.ToString("F2") + " m ");
            Console.WriteLine("Pressão Arterial: " + PressaoArterial.ToString("F2"));
            Console.WriteLine("Temperatura: " + Temperatura.ToString("F2") + " °C ");
            Console.WriteLine("Urgência de Atendimento: " + UrgenciaAtendimento);
            Console.WriteLine();
            Console.WriteLine("Dados da Consulta: ");
            Console.WriteLine("Nome do Médico: " + NomeMedico);
            Console.WriteLine("CRM do Médico: " + CrmMedico);
            Console.WriteLine("Prescrição Médica: " + PrescricaoMedica);
            Console.WriteLine();
        }

            public virtual void ImprimirDados()
            {
            Console.WriteLine();
            Console.WriteLine("Dados do Paciente:");
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("CPF: " + Cpf);
            Console.WriteLine("Data de Nascimento: " + DataNascimento);
            Console.WriteLine("E-mail: " + Email);
            Console.WriteLine();
            Console.WriteLine("Dados da Triagem:");
            Console.WriteLine("Peso: " + Peso);
            Console.WriteLine("Altura: " + Altura);
            Console.WriteLine("Pressão Arterial: " + PressaoArterial);
            Console.WriteLine("Temperatura: " + Temperatura);
            Console.WriteLine("Urgência de Atendimento: " + UrgenciaAtendimento);
        }
    }
}
