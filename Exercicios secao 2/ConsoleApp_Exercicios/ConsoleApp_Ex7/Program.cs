using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Ex7 {
    class Program {
        static void Main(string[] args) {

            int entrada = -1;
            while (entrada != 0) {
                Console.WriteLine("Entrada?");
                entrada = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                int saida = entrada * entrada;
                Console.WriteLine("Saída: " + saida);
                
            }

        }
    }
}
