using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.WriteLine("Avalie meu atendimento de 1 a 5!");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota)
            {
                case 0:
                    Console.WriteLine("Pessimo");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Bom mermão!");
                    break ; 
                case 6:
                    Console.WriteLine("Bagulho tá ótimo, bora continuar!");
                    break;
                default:
                    Console.WriteLine("Nota invalida!");
                    break;

            }
        }

    }
}
