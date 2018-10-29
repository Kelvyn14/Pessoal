using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Propostos3 {
    class Aluno {
        public string nome;
        public double nota1;
        public double nota2;
        public double nota3;

        public double notaFinal() {
            return nota1 + nota2 + nota3;
        }

        public override string ToString() {
            return "NOTA FINAL = "
                + notaFinal().ToString("F2", CultureInfo.InvariantCulture)
                + "\n"
                + (notaFinal() >= 60 ? "APROVADO" : "REPROVADO")
                + (notaFinal() < 60 ? "\nFALTAM " + (60 - notaFinal()).ToString("F2",CultureInfo.InvariantCulture) + " PONTOS" : "");



        }
    }
}
