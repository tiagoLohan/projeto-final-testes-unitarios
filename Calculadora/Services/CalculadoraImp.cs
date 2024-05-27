using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public int Somar(int num1, int num2)
        {
            int resp = num1 + num2;
            return resp;
        }

        public int Subtrair(int num1, int num2)
        {
            int resp = num1 - num2;
            return resp;
        }

        public int Multiplicar(int num1, int num2)
        {
            int resp = num1 * num2;
            return resp;
        }

        public int Dividir(int num1, int num2)
        {
            int resp = num1 / num2;
            return resp;
        }
    }
}