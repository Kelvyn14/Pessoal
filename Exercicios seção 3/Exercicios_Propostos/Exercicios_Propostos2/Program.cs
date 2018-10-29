using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Propostos2 {
    class Program {
        static void Main(string[] args) {

            Funcionario F = new Funcionario();

            Console.Write("Nome: ");
            F.nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            F.salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Desconto: ");
            F.desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(F);

            Console.Write("Deseja aumentar o salário em qual porcentagem? ");
            F.aumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine(F);
            Console.ReadLine();
        }
    }
}
