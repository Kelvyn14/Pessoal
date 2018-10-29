using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Ex6 {
    class Program {
        static void Main(string[] args) {

            
            string[] array = Console.ReadLine().Split(' ');
            int num1 = int.Parse(array[0],CultureInfo.InvariantCulture), num2 = int.Parse(array[1], CultureInfo.InvariantCulture);
            int soma = 0;

            for (int i = num1; i <= num2; i++) {
                if (i % 2 != 0) {
                    soma += i;
                }
            }

            Console.WriteLine("Resultado: " + soma);
            Console.ReadLine();

        }
    }
}
