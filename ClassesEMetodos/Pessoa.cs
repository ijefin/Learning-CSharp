﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Pessoa
    {
        public string Nome;
        public int Idade;
        public string Apresentar()
        {
            return string.Format($"Olá, me chamo {Nome} e tenho {Idade} anos!.");
        }

        public string Validar()
        {
            return Nome == "" || Idade == 0 ? "Dados inválidos!" : "Dados corretos";
            Console.WriteLine(Validar());
        }

        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }

        public void Zerar()
        {
            Nome = "";
            Idade = 0;
        }
    }
}
