using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Ex9 {
    class Program {
        static void Main(string[] args) {

            int vezesJogando = 0;
            double horasBateria = 0;

            string[] inputs = Console.ReadLine().Split(' ');

            horasBateria = double.Parse(inputs[0], CultureInfo.InvariantCulture);
            vezesJogando = int.Parse(inputs[1], CultureInfo.InvariantCulture);

            for (int i = 2; i < vezesJogando + 2; i++) {
                horasBateria = horasBateria - double.Parse(inputs[i], CultureInfo.InvariantCulture);
                if (horasBateria >= 0) {
                    Console.WriteLine(horasBateria.ToString("F2", CultureInfo.InvariantCulture));
                }
                else {
                    Console.WriteLine("Recarregar");
                }
            }

            Console.ReadLine();
        }
    }
}
