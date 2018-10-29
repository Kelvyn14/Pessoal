using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Ex4 {
    class Program {
        static void Main(string[] args) {
            //exercicio 4

            double txGlicose = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (txGlicose <= 100) {
                Console.WriteLine("NORMAL");
            }
            else if (txGlicose > 100 && txGlicose <= 140) {
                Console.WriteLine("ELEVADO");
            }
            else if (txGlicose > 140) {
                Console.WriteLine("DIABETES");
            }

            Console.ReadLine();
        }
    }
}
