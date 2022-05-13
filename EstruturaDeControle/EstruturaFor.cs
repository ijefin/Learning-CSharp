using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaFor
    {
        public static void Executar()
        {

            double somatorio = 0;
            string entrada;

            Console.WriteLine("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoDaTurma);

            //for(int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine($"O valor de i é {i}");
            //}

            for (int i = 0; i <= tamanhoDaTurma; i++)
            {
                Console.WriteLine($"Informe a nota do {i}º aluno");
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;

            }

            double media = tamanhoDaTurma > 0 ? somatorio / tamanhoDaTurma : 0;
            Console.WriteLine($"A média da turma é {media}");
        }
    }
}
