using System;
using System.Collections.Generic;
using System.Text;

namespace NewTalents
{
    public interface ICalculadora
    {
        int Somar(int valor1, int valor2);
        int Subtrair(int valor1, int valor2);
        int Multiplicar(int valor1, int valor2);
        int Dividir(int valor1, int valor2);
        List<string> Historico();
    }
}
