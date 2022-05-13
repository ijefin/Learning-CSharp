using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class Break
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);

            for (int i = 0; i <= 50; i++)
            {
                if (i == numero)
                {
                    Console.WriteLine("Sim!");
                    break;
                }
                else
                {
                    Console.WriteLine("Não");
                }
            }
        }
    }
}
