using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Ex2 {
    class Program {
        static void Main(string[] args) {
            // exercíco 2
            double N1, N2, N3, NF;

            Console.WriteLine("Digite suas 3 notas: ");
            string[] vet = Console.ReadLine().Split(' ');

            N1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            N2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            N3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            NF = N1 + N2 + N3;

            if (NF > 60.0) {
                Console.WriteLine("Nota Final: " + NF.ToString("F2", CultureInfo.InvariantCulture));
            }
            else {
                Console.WriteLine("Nota Final: " + NF.ToString("F2",CultureInfo.InvariantCulture) + " DEPENDÊNCIA");
            }
            Console.ReadLine();
        }
    }
}
