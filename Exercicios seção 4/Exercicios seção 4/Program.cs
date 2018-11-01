using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_seção_4 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o número da conta: ");
            int conta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o nome do titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char depositoInicial = char.Parse(Console.ReadLine());
            double deposito = 0;

            if (depositoInicial == 's') {
                Console.Write("Digite o valor do depósito inicial: ");
                deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                                
            }

            Conta C = new Conta(conta, titular, deposito);
            Console.WriteLine("Conta criada:\n" + C);

            Console.Write("Digite um valor para depósito: ");
            double novoDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C.deposito(novoDeposito);
            Console.WriteLine("Conta atualizada:\n" + C);

            Console.Write("Digite um valor para saque: ");
            double novoSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C.saque(novoSaque);
            Console.WriteLine("Conta atualizada:\n" + C);

            Console.ReadLine();

        }
    }
}
