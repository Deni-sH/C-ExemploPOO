using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public abstract class Conta //abstract só vai servir para ser herdada
    {
        protected decimal saldo; //protegido das alterações externas com exceção das suas classes filhas

        public abstract void Creditar(decimal valor); // não é implementada, então quem herdá-la vai precisar instanciá-la

        public void ExibirSaldo()
        {
            Console.WriteLine("O seu saldo é: " + saldo); 
        }
    }
}