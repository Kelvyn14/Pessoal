using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Propostos2 {
    class Funcionario {
        public string nome;
        public double salarioBruto;
        public double desconto;

        public double salarioLiquido() {
            return salarioBruto - desconto;
        }

        public void aumentarSalario(double porcentagem) {
            salarioBruto = salarioBruto + (salarioBruto * porcentagem / 100);
        }

        public override string ToString() {
            return "Dados do funcionário: "
                + nome
                + ", R$"
                + salarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
