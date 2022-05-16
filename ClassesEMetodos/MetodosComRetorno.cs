using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{

    class CalculadoraComum
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }
        public int Subtrair(int a, int b)
        {
            return a - b;
        }
        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
        public int Dividir(int a, int b)
        {
            return a / b;
        }
    }

    class CalculadoraEmCadeia
    {
        int memoria;

        public CalculadoraEmCadeia Somar(int a)
        {
            memoria += a;
            return this;
        }
        public CalculadoraEmCadeia Subtrair(int a)
        {
            memoria -= a;
            return this;
        }
        public CalculadoraEmCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }
        public CalculadoraEmCadeia Dividir(int a)
        {
            memoria /= a;
            return this;
        }

        public CalculadoraEmCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }

        public CalculadoraEmCadeia Limpar()
        {
            memoria = 0;
            return this;
        }

        public int Resultado()
        {
            return memoria;
        }
    }
    internal class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadoraCadeia = new CalculadoraEmCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(5).Imprimir();

            var resultado = calculadoraCadeia.Resultado();
            Console.WriteLine(resultado);

        }
    }
}
