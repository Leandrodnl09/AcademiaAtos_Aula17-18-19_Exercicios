using System.Drawing;

namespace AcademiaAtos_Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 - Crie uma classe chamada ContaBancaria que tenha as propriedades NumeroConta, Titular, Saldo e Limite. Crie também
            // um método chamado Depositar, que recebe um valor e adiciona ao saldo da conta, e um método Sacar, que recebe um
            // valor e verifica se o saldo é suficiente para a operação.

            // criando uma nova conta bancária
            ContaBancaria conta = new ContaBancaria
            {
                NumeroConta = 123,
                Titular = "João",
                Saldo = 1000.00m,
                Limite = 500.00m
            };

            // exibindo o menu
            while (true)
            {
                Console.WriteLine("1 - Depositar");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("3 - Ver saldo");
                Console.WriteLine("0 - Sair");

                // lendo a opção escolhida pelo usuário
                Console.Write("Escolha uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o valor a ser depositado: ");
                        decimal valorDeposito = decimal.Parse(Console.ReadLine());
                        conta.Depositar(valorDeposito);
                        Console.WriteLine("Depósito realizado com sucesso!");
                        break;
                    case 2:
                        Console.Write("Digite o valor a ser sacado: ");
                        decimal valorSaque = decimal.Parse(Console.ReadLine());
                        if (conta.Sacar(valorSaque))
                        {
                            Console.WriteLine("Saque realizado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Saldo insuficiente para o saque.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Saldo atual: R${0}", conta.Saldo);
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}