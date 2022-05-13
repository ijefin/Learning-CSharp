using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaForeach
    {
        public static void Executar()
        {
            string ola = "Meu Pau Grossão!";

            foreach (var teste in ola)
            {
                Console.WriteLine(teste);
            }
        }
    }
}
