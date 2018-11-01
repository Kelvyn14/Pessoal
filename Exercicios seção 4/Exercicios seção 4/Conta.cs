using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_seção_4 {
    class Conta {
        public int numero { get; private set; }
        public string nome { get; set; }

        public double saldo { get; private set; }

        public Conta(int numero, string nome, double depositoValor) {
            this.numero = numero;
            this.nome = nome;
            this.saldo = depositoValor;
        }

        public Conta(int numero, string nome) {
            this.numero = numero;
            this.nome = nome;
            this.saldo = 0;
        }

        public void deposito(double valor) {
            saldo = saldo + valor;
        }
        public void saque(double valor) {
            saldo = saldo - valor - 5;
        }

        public override string ToString() {
            return "Conta "
                + numero
                + ", Titular: "
                + nome
                + ", Saldo: R$"
                + saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
