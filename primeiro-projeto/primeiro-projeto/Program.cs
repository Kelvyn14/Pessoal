using System;
using System.Globalization;

namespace primeiro_projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //double x = 10.35784;
            //Console.WriteLine(x);
            //Console.WriteLine(x.ToString("F2"));
            //Console.WriteLine(x.ToString("F4"));
            //Console.WriteLine(x.ToString("F2",CultureInfo.InvariantCulture));            
            //Console.ReadLine();

            string x;
            int y;
            double z;
            char w;

            x = Console.ReadLine();
            y = int.Parse(Console.ReadLine());           
            z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            w = char.Parse(Console.ReadLine());

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(w);
            Console.ReadLine();
        }
    }
}
