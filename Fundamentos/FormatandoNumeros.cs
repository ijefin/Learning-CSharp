using System;

using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class FormatandoNumeros
    {
        public static void Executar()
        {
            double tamanhoDoMeuPau = 13.5234;
            //Casa décimal
            Console.WriteLine(tamanhoDoMeuPau.ToString("F1"));
            //Currency
            Console.WriteLine(tamanhoDoMeuPau.ToString("C"));
            //Porcento
            Console.WriteLine(tamanhoDoMeuPau.ToString("P"));
            //Décimal com Cerquilha
            Console.WriteLine(tamanhoDoMeuPau.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(tamanhoDoMeuPau.ToString("C", cultura));

            int numero = 10;
            Console.WriteLine(numero.ToString("D6"));

        }
    }
}
