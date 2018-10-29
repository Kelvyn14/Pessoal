using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso {
    class Program {
        static void Main(string[] args) {
            //calcula da área de dois triangulos e comparação sobre qual triângulo possui a maior área.

            Triangulo X, Y;
            double areaX, areaY, p;

            X = new Triangulo();
            Y = new Triangulo();

            X.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            areaX = X.area();
            areaY = Y.area();


            Console.WriteLine("AREA DO TRIANGULO X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("AREA DO TRIANGULO Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY) {
                Console.WriteLine("TRIANGULO DE MAIOR AREA: X");
            }
            else if(areaY > areaX) {
                Console.WriteLine("TRIANGULO DE MAIOR AREA: Y");
            }
            else {
                Console.WriteLine("AREAS IGUAIS");
            }
            Console.ReadLine();
        }
    }
}
