using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Exercicios_Secao2 {
    class Program {
        static void Main(string[] args) {
            //exercicio 1
            int volume, vazao, tempo;

            Console.WriteLine("digite o Volume, a vazão e o tempo:");
            string[] vet = Console.ReadLine().Split(' ');

            volume = int.Parse(vet[0]);
            vazao = int.Parse(vet[1]);
            tempo = int.Parse(vet[2]);

            for (int i = tempo; i > 0; i--) {
                volume = volume - vazao;
            }

            if (volume >= 0) {
                Console.WriteLine("Sobrou :" + volume.ToString(), CultureInfo.InvariantCulture);
            }
            else {
                Console.WriteLine("Não é possível");
            }
            Console.ReadLine();
        }
    }
}
