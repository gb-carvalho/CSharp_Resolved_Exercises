using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorContaBancaria
{
    public class ContaBancaria
    {
        public int Numero { get; private set; }
        public string? Titular { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria() { }

        public ContaBancaria(int numero, string? titular) {
            this.Numero = numero;
            this.Titular = titular;
        }

        public ContaBancaria(int numero, string? nome, double depositoInicial) : this(numero, nome)
        {
            Deposito(depositoInicial);
        }

        override public string ToString()
        {
            return $"Conta: {Numero}, Titular: {Titular}, Saldo: R${Saldo:F2}";
        }

        public void Deposito(double valor_deposito)
        {
            this.Saldo += valor_deposito;
        }

        public void Saque(double valor_saque)
        {
            this.Saldo -= valor_saque + 5.00;
        }
    }
}
