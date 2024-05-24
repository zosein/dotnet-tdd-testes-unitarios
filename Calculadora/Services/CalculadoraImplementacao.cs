using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImplementacao
    {
        public int Somar(int a, int b) => a + b;
        public int Subtrair(int a, int b) => a - b;
        public int Multiplicar(int a, int b) => a * b;
        public int Dividir(int a, int b) => a / b;
    }
}