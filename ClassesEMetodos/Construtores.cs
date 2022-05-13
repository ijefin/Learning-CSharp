using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Jogos
    {
        public string Nome;
        public string Categoria;
        public string Plataforma;
        public int Ano;

        public Jogos(string nome, string categoria, string plataforma, int ano)
        {
            Nome = nome;
            Categoria = categoria;
            Plataforma = plataforma;
            Ano = ano;
        }

        public Jogos()
        {

        }
    }

    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
    }
    class Construtores
    {
        public static void Executar()
        {
            var carro1 = new Carro("BMW", "320i", 2021);
            Console.WriteLine($"{carro1.Fabricante} | {carro1.Modelo} | {carro1.Ano}");

            var jogo1 = new Jogos()
            {
                Ano = 1996,
                Categoria = "Aventura",
                Nome = "Legend of Zelda - A Ocarina of time",
                Plataforma = "PC, Nintendo Wii, Nintendo3DS",

            };

            Console.WriteLine($"{jogo1.Plataforma}");
        }
    }
}
