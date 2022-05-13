using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadorUnario
    {
        public static void Executar()
        {
            var numero1 = 5;
            var numero2 = 6;

            numero1++;
            Console.WriteLine(numero1);

            --numero1;
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2);
        }
    }
}
