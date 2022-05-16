using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class AtributosEstaticos
    {
        public class Produto
        {
            public string Nome;
            public double Preco;
            public static double Desconto;
            public string Descricao;

            public Produto()
            {
            }

            public Produto(string nome, double preco, double desconto, string descricao)
            {
                Nome = nome;
                Preco = preco;
                Desconto = desconto;
                Descricao = descricao;
            }

            public double CalcularDesconto()
            {
                return Preco - Preco * Desconto;
            }
        }
        public static void Executar()
        {
            var produto1 = new Produto("Caneta", 3.50, 0.1, "Caneta Bic Azul");
            var produto2 = new Produto("Lápis", 1.0, 0.1, "Lapis Faber Castel");

            var produto3 = new Produto()
            {
                Nome = "Borracha",
                Preco = 0.50,
                Descricao = "Borracha branca Faber Castel"
            };

            Console.WriteLine($"Preco com desconto {produto1.CalcularDesconto()}");
            Console.WriteLine($"Preco com desconto {produto2.CalcularDesconto()}");
            Console.WriteLine($"Preco com desconto {produto3.CalcularDesconto()}");

            Produto.Desconto = 0.25;
        }
    }
}