using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07Enumeratory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj miasto");
            string miasto = Console.ReadLine();

            List<Jednostka> jednostki= Enum.GetValues(typeof(Jednostka)).Cast<Jednostka>().ToList();
            Console.WriteLine("podaj jednostkę jedną z:" + string.Join(", ", jednostki));

            string jednostka = Console.ReadLine();
            bool czyPoprawana= Enum.TryParse(jednostka, out Jednostka jednostkaEnum);

            if (czyPoprawana)
            {
                ManagerPogody mp = new ManagerPogody();
                double temp = mp.PodajTemperature("warszawa", jednostkaEnum);
                Console.WriteLine(temp);
            }
            else
            {
                Console.WriteLine("Nieznana jednostka");
            }
            Console.ReadKey();
            

        }
    }
}
