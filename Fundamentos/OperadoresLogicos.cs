using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalhoUm = true;
            var executouTrabalhoDois = false;

            bool comprouTv50 = executouTrabalhoUm && executouTrabalhoDois;
            Console.WriteLine($"Comprou a tv? {comprouTv50}");

            bool comprouTv32 = executouTrabalhoUm || executouTrabalhoDois;
            Console.WriteLine($"Comprou a tv de 32? {comprouTv50}");

            bool comprouSorvete = executouTrabalhoUm ^ executouTrabalhoDois;
            Console.WriteLine($"Comprou um sorvete? {comprouSorvete}");

            bool estaCerto = !comprouSorvete;
            Console.WriteLine($"Esta certo? {estaCerto}");
        }
    }
}
