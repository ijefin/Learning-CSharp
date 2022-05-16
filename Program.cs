using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios", Comentarios.Executar},
                {"Variáveis e Constantes", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Notação Ponto", NotaçãoPonto.Executar},
                {"Input", LendoDados.Executar},
                {"Formatando Números", FormatandoNumeros.Executar},
                {"Convertendo Números", ConvertendoNumeros.Executar},
                {"Operadores Lógicos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição", OperadoresDeAtribuicao.Executar},
                {"Operador Unário", OperadorUnario.Executar},
                {"Operador Ternário", OperadorTernario.Executar},

                //Estruturas de controle
                {"Estrutura IF - Estruturas de controle", EstruturaIf.Executar},
                {"Estrutura SWITCH - Estruturas de controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de controle", EstruturaWhile.Executar},
                {"Estrutura DoWhile - Estruturas de controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de controle", EstruturaFor.Executar},
                {"Estrutura ForEach - Estruturas de controle", EstruturaForeach.Executar},
                {"Estrutura Break - Estruturas de controle", Break.Executar},
                {"Estrutura Continue - Estruturas de controle", Continue.Executar},

                //Classes e Métodos
                {"Classes - Classes e Métodos", Membros.Executar},
                {"Classes - Construtores", Construtores.Executar},
                {"Classes - Metodos com Retorno", MetodosComRetorno.Executar},
                {"Classes - Metodos Estaticos", Estatico.Executar},
                {"Classes - Atributos Estaticos", AtributosEstaticos.Executar},
                {"Classes - Desafio", DesafioAtributo.Executar},
                {"Classes - Params", Params.Executar},
                {"Classes - Params com nome", ParamsNomeados.Executar},
                {"Classes - Getters & Setters", Getset.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}