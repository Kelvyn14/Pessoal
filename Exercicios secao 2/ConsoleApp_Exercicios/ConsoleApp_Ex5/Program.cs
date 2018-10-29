using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Ex5 {
    class Program {
        static void Main(string[] args) {
            //execicios de distancia dos dardos

            //string input = Console.ReadLine();
            //while (input != "S") {
            Console.WriteLine("distâncias? ");
            string[] distancias = Console.ReadLine().Split(' ');
            double maiorDistancia = 0;

            for (int i = 0; i < distancias.Length; i++) {
                double atualDistancia = double.Parse(distancias[i], CultureInfo.InvariantCulture);
                if (i > 0) {
                    double anteriorDistancia = double.Parse(distancias[i - 1], CultureInfo.InvariantCulture);
                    if (atualDistancia > anteriorDistancia) {
                        if (atualDistancia > maiorDistancia) {
                            maiorDistancia = atualDistancia;
                        }
                    }
                    else {
                        if (anteriorDistancia > maiorDistancia) {
                            maiorDistancia = anteriorDistancia;
                        }                        
                    }
                }
            }

            Console.WriteLine(maiorDistancia.ToString("F2", CultureInfo.InvariantCulture));
            //}

            Console.ReadLine();
        }
    }
}
