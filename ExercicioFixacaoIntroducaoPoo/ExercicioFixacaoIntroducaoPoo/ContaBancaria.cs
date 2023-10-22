using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoIntroducaoPoo
{
    internal class ContaBancaria
    {
        private double _taxaSaque = 5d;
        public string Conta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        internal ContaBancaria(string conta, string nome)
        {
            Conta = conta;
            Nome = nome;
        }

        internal ContaBancaria(string conta, string nome, double depositoInicial) : this(conta, nome)
        {
            Deposito(depositoInicial);
        }

        public override string ToString()
        {
            return $"Conta {Conta}, Titular: {Nome}, Saldo: R${Saldo.ToString("F2")}";
        }

        internal void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        internal void Saque(double saque)
        {
            Saldo -= (saque + _taxaSaque);
        }
    }
}
