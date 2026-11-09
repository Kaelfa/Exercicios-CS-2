using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios
{
    public class Calculadora
    {
        public decimal Somar(decimal val1, decimal val2)
        {
            return val1 + val2;
        }
        public decimal Subtrair(decimal val1, decimal val2)
        {
            return val1 - val2;
        }
        public decimal Multiplicar(decimal val1, decimal val2)
        {
            return val1 * val2;
        }
        public static decimal Divisao(decimal val1, decimal val2)
        {
            if (val2 != 0)
                return val1 / val2;
            else
                Console.WriteLine("Divisao por 0");
                return 0;
        }
    }
}