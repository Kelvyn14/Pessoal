using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Ex3 {
    class Program {
        static void Main(string[] args) {
            // exercicio 3
            string[] dimFoto = Console.ReadLine().Split(' ');
            string[] dimPortaRetrato = Console.ReadLine().Split(' ');

            int largFoto, altFoto, largPort, altPort;
            largFoto = int.Parse(dimFoto[0]);
            altFoto = int.Parse(dimFoto[1]);
            largPort = int.Parse(dimPortaRetrato[0]);
            altPort = int.Parse(dimPortaRetrato[1]);

            if (largFoto <= largPort && altFoto <= altPort) {
                Console.WriteLine("SIM");
            }
            else if (largFoto <= altPort && altFoto <= largPort) {
                Console.WriteLine("SIM");
            }
            else {
                Console.WriteLine("NÃO");
            }
            Console.ReadLine();

        }
    }
}
