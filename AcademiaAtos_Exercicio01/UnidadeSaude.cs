using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio01
{
    internal class UnidadeSaude
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public UnidadeSaude Responsavel { get; set; }

        public UnidadeSaude()
        {
            Responsavel = new UnidadeSaude();
        }

        public UnidadeSaude(string nome, string sigla)
        {
            Nome = nome.ToUpper();
            Sigla = sigla.ToUpper();
            Responsavel = new UnidadeSaude();

        }

        public UnidadeSaude(string nome)
        {
            Nome = nome.ToUpper();
            Responsavel = new UnidadeSaude();
        }

    }
}
