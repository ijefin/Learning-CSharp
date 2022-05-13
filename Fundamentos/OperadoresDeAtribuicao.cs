using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresDeAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            num1 = 7;

            num1 += 10;
            Console.WriteLine(num1);
            num1 -= 10;
            Console.WriteLine(num1);
            num1 *= 10;
            Console.WriteLine(num1);
            num1 /= 10;
            Console.WriteLine(num1);

        }
    }
}
