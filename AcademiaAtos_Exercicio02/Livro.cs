using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio02
{
    internal class Livro
    {
        private string _titulo;
        private Autor _autor;

        public Livro(string titulo, Autor autor)
        {
            Titulo = titulo;
            Autor = autor;
        }

        public string Titulo
        {
            get => _titulo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("O título não pode ser vazio.");
                _titulo = value;
            }
        }

        public Autor Autor
        {
            get => _autor;
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(value), "O autor não pode ser nulo.");
                _autor = value;
            }
        }
    }
}
