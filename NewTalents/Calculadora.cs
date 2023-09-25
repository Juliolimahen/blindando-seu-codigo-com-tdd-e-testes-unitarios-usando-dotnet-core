using System;
using System.Collections.Generic;
using System.Text;

namespace NewTalents
{
    public class Calculadora : ICalculadora
    {
        private readonly List<string> _listaHistorico;
        public DateTime Data { get; set; }

        public Calculadora(DateTime data)
        {
            Data = data;
            _listaHistorico = new List<string>();
        }

        public int Dividir(int valor1, int valor2)
        {
            int resultado = valor1 / valor2;
            InserirNoHistoricoDeOperacoes(resultado);
            return resultado;
        }

        public List<string> Historico()
        {
            _listaHistorico.RemoveRange(3, _listaHistorico.Count - 3);
            return _listaHistorico;
        }

        public int Multiplicar(int valor1, int valor2)
        {
            int resultado = valor1 * valor2;
            InserirNoHistoricoDeOperacoes(resultado);
            return resultado;
        }

        public int Somar(int valor1, int valor2)
        {
            int resultado = valor1 + valor2;
            InserirNoHistoricoDeOperacoes(resultado);
            return resultado;
        }

        private void InserirNoHistoricoDeOperacoes(int resultado)
        {
            _listaHistorico.Insert(0, "Res: " + resultado +", data: "+ Data);
        }

        public int Subtrair(int valor1, int valor2)
        {
            int resultado = valor1 - valor2;
            InserirNoHistoricoDeOperacoes(resultado);
            return resultado;
        }
    }
}
