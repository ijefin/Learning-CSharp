using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadorTernario
    {
        public static void Executar()
        {
            var bomComportamento = true;
            var nota = 7;
            var resultado = nota >= 7 && bomComportamento ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);


        }
    }
}
