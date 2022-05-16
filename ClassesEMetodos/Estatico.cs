using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }

    internal class Estatico
    {
        public static void Executar()
        {
            //Atributo de classe
            var resultado = CalculadoraEstatica.Multiplicar(2, 5);
            Console.WriteLine(resultado);

            //Atributo de instância
            CalculadoraEstatica realizarSoma = new CalculadoraEstatica();
            Console.WriteLine(realizarSoma.Somar(2, 5)); ;
        }
    }
}
