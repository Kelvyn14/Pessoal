using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Ex8 {
    class Program {
        static void Main(string[] args) {
            int n, a, b;
            Console.WriteLine("Entradas?");
            string[] array = Console.ReadLine().Split(' ');

            n = int.Parse(array[0], CultureInfo.InvariantCulture);
            a = int.Parse(array[1], CultureInfo.InvariantCulture);
            b = int.Parse(array[2], CultureInfo.InvariantCulture);

            for (int i = a; i <= b; i++) {
                if (i % n == 0) {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

        }
    }
}
