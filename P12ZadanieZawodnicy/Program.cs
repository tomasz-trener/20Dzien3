using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P12ZadanieZawodnicy
{
    internal class Program
    {
        static void Main(string[] args)
        {

          

            ManagerZawodnikow mz = new ManagerZawodnikow();
            Zawodnik[] zawodnicy = mz.WczytajZawodnikow();
            // teraz mozemy wysiwtlic

            foreach (var z in zawodnicy)
            {
                Console.WriteLine(z.Imie + " " + z.Nazwisko + " " + z.Kraj);
            }
            Console.ReadKey();
        }
    }
}
