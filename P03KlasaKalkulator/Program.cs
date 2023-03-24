using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03KlasaKalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulator k = new Kalkulator();
            int a = 5;
            int w= k.Policz(4,a);
            Console.WriteLine(w);

            Console.ReadKey();
        }
    }
}
