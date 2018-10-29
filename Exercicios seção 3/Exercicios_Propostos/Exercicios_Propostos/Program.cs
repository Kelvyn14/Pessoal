using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Propostos {
    class Program {
        static void Main(string[] args) {

            /*Fazer um progrmaa para ler os valores de largura e altura de um retângulo. Em seguida, mostrar na tela o valor de 
            sua área, perímetro e diagonal.*/

            Retangulo R = new Retangulo();

            Console.Write("Digite a Largura do triângulo: ");
            R.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite a Altura do triângulo: ");
            R.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(R);
            Console.ReadLine();
        }
    }
}
