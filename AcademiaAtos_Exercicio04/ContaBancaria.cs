using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio04
{
    public class ContaBancaria
    {
        public int NumeroConta { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get;  set; }
        public decimal Limite { get; set; }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public bool Sacar(decimal valor)
        {
            if (Saldo + Limite >= valor)
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }
    }
}
