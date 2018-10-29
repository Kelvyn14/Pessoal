using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Propostos {
    class Retangulo {
        public double largura;
        public double altura;

        public double area() {
            return largura * altura;
        }

        public double perimetro() {
            return 2 * (largura + altura);
        }

        public double diagonal() {
            return Math.Sqrt((largura * largura) + (altura * altura));
        }

        public override string ToString() {
            return "AREA = "
                + area().ToString("F2", CultureInfo.InvariantCulture)
                + "\nPERIMETRO = "
                + perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + "\nDIAGONAL = "
                + diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
