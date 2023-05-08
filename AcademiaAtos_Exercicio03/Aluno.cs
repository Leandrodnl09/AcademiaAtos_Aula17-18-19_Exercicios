using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio03
{
    internal class Aluno
    {
        private string nome;
        private int matricula;

        public string Nome
        {
            get { return nome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                nome = value;
            }
        }

        public int Matricula
        {
            get { return matricula; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("A matrícula deve ser positiva");
                }

                matricula = value;
            }
        }
    }
}
