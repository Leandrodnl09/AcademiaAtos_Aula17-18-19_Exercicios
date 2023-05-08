using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio01
{
    internal class Fabricante
    {
        private string nome;
        private string endereco;
        private string cidade;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

    }
}
