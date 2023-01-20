using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploPOO.Interfaces;

namespace ExemploPOO.Models
{
    public class Calculadora : ICalculadora  //OBS: Clica na classe que da erro, ou quer implementar a interface. ou "CRTL + ."
    {
        public int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Multiplicar(int num1, int num2)
        {
        return num1 * num2;        }

        public int Subtrair(int num1, int num2)
        {
        return num1 - num2;
        }

        public int Somar(int num1, int num2, int num3)
        {
        return num1 + num2 + num3;
        }

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}