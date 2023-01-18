using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente //ctor = construtor
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }
        private decimal saldo;
        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
            saldo -= valor; //saldo = saldo - valor
            Console.WriteLine("Sacado com sucesso!");
            }
            else
            {
                Console.WriteLine("Valor desejado é maior que o saldo dispoivel.");
            }
        }
        public void ExibirSaldo()
        {
            Console.WriteLine("Seu saldo disponível é: " + saldo);
        }

    }
}