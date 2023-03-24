using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09Wlasciwosci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulator kalkulator = new Kalkulator();
            kalkulator.Kolor = "czerwony";

            Console.WriteLine(kalkulator.Kolor);

            ManagerPogody mp = new ManagerPogody();
            //mp.SzukanyZnak = "*";
            mp.ZnakKoncowy = "^";

            string nazwaSerwisu = mp.AdresSerwisu;
            

            Console.WriteLine("Korzystamy z serisu: " + nazwaSerwisu);

            double d= mp.PodajTemperature("Warszawa", Jednostka.Celsjusz);


            Czlowiek c = new Czlowiek();
        //    c.Wzrost = 4;
            c.Nazwisko = "a";

            c.ImieNazwisko = "Jan Kowalski";
        
        }
    }
}
