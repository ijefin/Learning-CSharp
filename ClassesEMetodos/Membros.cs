using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Membros
    {
        public static void Executar()
        {
            Pessoa alguem = new Pessoa();
            alguem.Nome = "Jefferson Lucas";
            alguem.Idade = 20;
            var apresentarAlguem = alguem.Apresentar();
            Console.WriteLine(apresentarAlguem);
            var validacao = alguem.Validar();
            Console.WriteLine(validacao);

            var alguem2 = new Pessoa();
            alguem2.Nome = "Anna Luiza";
            alguem2.Idade = 19;
            var apresentarAlguem2 = alguem2.Apresentar();
            Console.WriteLine(apresentarAlguem2);

            var alguem3 = new Pessoa();
            alguem3.Nome = "Giovanna Victoria";
            alguem3.Idade = 16;
            var apresentarAlguem3 = alguem3.Apresentar();
            Console.WriteLine(apresentarAlguem3);
            alguem3.Zerar();
            alguem3.ApresentarNoConsole();
            var validacao3 = alguem3.Validar();
            Console.WriteLine(validacao3);



        }
    }
}
