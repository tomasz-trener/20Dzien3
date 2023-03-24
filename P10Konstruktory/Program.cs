using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10Konstruktory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulator k = new Kalkulator("normlany");

           // k.Tryb = "normalny";
            k.Policz(2, 3);


            //ManagerPogody mp = new ManagerPogody();
            //double d1= mp.PodajTemperature("warszawa", Jednostka.Kelvin);
            //double d2 = mp.PodajTemperature("kraków", Jednostka.Kelvin);
            ManagerPogody mp = new ManagerPogody(Jednostka.Kelvin);
            double d1 = mp.PodajTemperature("warszawa");
            double d2 = mp.PodajTemperature("kraków");

        }
    }
}
