using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Propostos3 {
    class Program {
        static void Main(string[] args) {
            Aluno A = new Aluno();

            Console.Write("Nome: ");
            A.nome = Console.ReadLine();

            Console.Write("Nota 1: ");
            A.nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Nota 2: ");
            A.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Nota 3: ");
            A.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(A);
            Console.ReadLine();
        }
    }
}
