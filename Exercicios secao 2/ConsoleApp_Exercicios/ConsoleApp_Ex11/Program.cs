using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Ex11 {
    class Program {
        static void Main(string[] args) {
            int entrada = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            int volume = entrada;

            while (entrada != 0) {
                entrada = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                               
                volume = volume + entrada;
                
                if (volume < 0) {
                    volume = 0;                    
                }
                else if (volume > 100) {
                    volume = 100;
                }
                Console.WriteLine(volume.ToString("F0"));                
            }
        }
    }
}
