using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio05
{
    internal class Animal
    {
        public string Nome { get; set; }
        public string Especie { get; set; }
        public int Idade { get; set; }

        public void EmitirSom()
        {
            if (Especie == "cachorro")
            {
                Console.WriteLine($"{Nome} ({Idade} anos): Au au!");
            }
            else if (Especie == "gato")
            {
                Console.WriteLine($"{Nome} ({Idade} anos): Miau!");
            }
            else if (Especie == "boi")
            {
                Console.WriteLine($"{Nome} ({Idade} anos): Muuuu!");
            }
            else if (Especie == "galinha")
            {
                Console.WriteLine($"{Nome} ({Idade} anos): Cocoricó!");
            }
            else if (Especie == "papagaio")
            {
                Console.WriteLine($"{Nome} ({Idade} anos): Meu Palmeiras!");
            }
            else
            {
                Console.WriteLine($"{Nome} ({Idade} anos): Não sei emitir som!");
            }
        }
    }
}
