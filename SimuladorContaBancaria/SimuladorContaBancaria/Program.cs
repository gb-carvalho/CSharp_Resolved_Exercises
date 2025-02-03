using SimuladorContaBancaria;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

/*
Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do
titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta. Este valor de depósito
inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro a depositar no momento de abrir sua
conta, o depósito inicial não será feito e o saldo inicial da conta será, naturalmente, zero.
Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado. Já
o nome do titular pode ser alterado (pois uma pessoa pode mudar de nome por ocasião de casamento, por
exemplo).
Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para proteger
isso. O saldo só aumenta por meio de depósitos, e só diminui por meio de saques. Para cada saque
realizado, o banco cobra uma taxa de $ 5.00. Nota: a conta pode ficar com saldo negativo se o saldo não for
suficiente para realizar o saque e/ou pagar a taxa.
Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não
informado o valor de depósito inicial. Em seguida, realizar um depósito e depois um saque, sempre
mostrando os dados da conta após cada operação. 
*/

namespace SimaldorContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria? contaBancaria = AbrirConta();
            if (contaBancaria == null)
            {
                Console.WriteLine("Erro ao abrir conta.");
                return;
            }

            Console.WriteLine("\nDados da conta:\n" + contaBancaria + "\n");

            Console.Write("Entre um valor para depósito: ");
            contaBancaria.Deposito(double.TryParse(Console.ReadLine(), out double valor_deposito) ? valor_deposito : 0.0 );
            Console.WriteLine("Dados da conta atualizados:\n" + contaBancaria + "\n");

            Console.Write("Entre um valor para saque: ");
            contaBancaria.Saque(double.TryParse(Console.ReadLine(), out double valor_saque) ? valor_saque : 0.0);
            Console.WriteLine("Dados da conta atualizados:\n" + contaBancaria + "\n");
        }

        static ContaBancaria? AbrirConta() {
            int numero;
            string? titular, depositoInicial;
            ContaBancaria contaBancaria;

            Console.Write("Entre o número da conta: ");
            numero = int.TryParse(Console.ReadLine(), out numero) ? numero : 0;

            Console.Write("Entre o titular da conta: ");
            titular = Console.ReadLine();

            Console.Write("Haverá deposito incial (s/n)? ");

            depositoInicial = Console.ReadLine();
            if (depositoInicial == "s" || depositoInicial == "S")
            {
                double valor;
                Console.Write("Entre o valor de depósito inicial: ");
                valor = double.TryParse(Console.ReadLine(), out valor) ? valor : 0;
                contaBancaria = new ContaBancaria(numero, titular, valor);
                return contaBancaria;

            }
            else if (depositoInicial == "n" || depositoInicial == "N")
            {
                contaBancaria = new ContaBancaria(numero, titular);
                return contaBancaria;
            }
            else
            {
                Console.WriteLine("Opção inválida");
                return null;
            }
        }
    }
}