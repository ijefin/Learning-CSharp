namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaWhile
    {
        public static void Executar()
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 16);
            int suaJogada;
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;


            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.WriteLine("Digite um valor de 1 a 15:");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out suaJogada);

                tentativasRestantes--;
                tentativas++;

                if (numeroSecreto == suaJogada)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Você adivinhou o número secreto!");
                    Console.WriteLine($"Numero encontrado em {tentativas} tentativas");
                    Console.BackgroundColor = corAnterior;

                }
                else if (numeroSecreto < suaJogada)
                {
                    Console.WriteLine($"O número secreto é menor que {suaJogada}");
                    Console.WriteLine($"Tentativas restantes: {tentativasRestantes}");
                }
                else
                {
                    Console.WriteLine($"O número secreto é maior que {suaJogada}");
                    Console.WriteLine($"Tentativas restantes: {tentativasRestantes}");

                }

            }

        }
    }
}
