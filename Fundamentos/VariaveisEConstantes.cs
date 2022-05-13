using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            double raio = 4.5;
            const double PI = 3.14;
            double area = PI * raio * raio;
            //Se houver uma concatenação no inicio, a soma é anulada mesmo que seja de um número com outro.
            //Console.WriteLine("A area da circunferência é: " + area + 1000);
            Console.WriteLine("A area da circunferência é: " + (area + 1000));

            //Tipos primitivos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo?" + estaChovendo);

            byte idadeMax = byte.MinValue;
            byte idade = byte.MaxValue;
            Console.Write(idade + " " + idadeMax);

            sbyte deSaldoDeGols = sbyte.MinValue;
            sbyte saldoDeGols = sbyte.MaxValue;
            Console.WriteLine(deSaldoDeGols  + " " + saldoDeGols);

            short valorShort = short.MinValue;
            short maxShortValue = short.MaxValue;
            Console.Write(valorShort + " " + maxShortValue);

            int minInt = int.MinValue;
            int maxInt = int.MaxValue;
            Console.WriteLine(minInt + " " + maxInt);
        }

    }
}
