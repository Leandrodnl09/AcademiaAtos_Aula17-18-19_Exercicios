using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio01
{
    internal class ProfissionalSaude
    {
        public string Nome { get; set; }

        public string Tipo { get; set; }

        public string RegistroConselho { get; set; }

        public ProfissionalSaude(string nome, string tipo, string registroConselho)
        {
            Nome = nome.ToUpper();
            Tipo = tipo.ToUpper();
            RegistroConselho = registroConselho.ToUpper();
        }

        public string SobreNome()
        {
            string[] lista = Nome.Split(',');
            return lista[lista.Length - 1] + " - " + RegistroConselho;
        }
    }
}
