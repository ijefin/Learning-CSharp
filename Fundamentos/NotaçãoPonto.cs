using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class NotaçãoPonto
    {
        public static void Executar()
        {
            var saudacao = "Olá".ToUpper().Insert(3, " World").Replace("World", "Mundo").ToUpper();
            Console.WriteLine(saudacao);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
