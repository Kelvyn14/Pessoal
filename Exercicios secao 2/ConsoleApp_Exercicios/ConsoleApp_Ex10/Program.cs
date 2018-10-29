using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Ex10 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Quantidade de alunos no curso?");
            int qtdeAlunos = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double[] notasFinais = new double[qtdeAlunos];
            for (int i = 0; i < qtdeAlunos; i++) {
                Console.WriteLine("Notas do aluno " + (i + 1) + "?");
                string[] notas = Console.ReadLine().Split(' ');

                double n1, n2, n3;
                n1 = double.Parse(notas[0], CultureInfo.InvariantCulture);
                n2 = double.Parse(notas[1], CultureInfo.InvariantCulture);
                n3 = double.Parse(notas[2], CultureInfo.InvariantCulture);
                notasFinais[i] = n1 + n2 + n3;
            }

            for (int i = 0; i < notasFinais.Length; i++) {
                Console.WriteLine(notasFinais[i].ToString("F2",CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}
