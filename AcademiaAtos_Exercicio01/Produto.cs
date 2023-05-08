using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio01
{
    internal class Produto
    {
        private string nome;
        private Fabricante fabricante;
        private double preco;

        public string Nome
        {
            get { return nome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("O nome do produto não pode ser vazio.");
                nome = value;
            }
        }

        public Fabricante Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }

        public double Preco
        {
            get { return preco; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("O preço do produto não pode ser negativo.");
                preco = value;
            }
        }
    }
}
