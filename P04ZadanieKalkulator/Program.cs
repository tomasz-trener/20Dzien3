using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieKalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulator k = new Kalkulator();
            double wynik1 = k.WykonajDzialanie("4+5");
            double wynik2 = k.WykonajDzialanie(4, 5, '+');

            try
            {
                double wynik3 = k.WykonajDzialanie(4, 0, '/');
            }
            catch (Exception ex)
            {
                Console.WriteLine("problem z działaniem");
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
            
        }
    }
}
