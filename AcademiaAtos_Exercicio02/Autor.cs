using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio02
{
    internal class Autor
    {
        private string _nome;

        public Autor(string nome)
        {
            Nome = nome;
        }

        public string Nome
        {
            get => _nome;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("O nome do autor não pode ser vazio.");
                _nome = value;
            }
        }
    }
}

