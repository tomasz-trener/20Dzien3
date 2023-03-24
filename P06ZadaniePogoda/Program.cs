using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06ZadaniePogoda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManagerPogody mp = new ManagerPogody();

            try
            {
                double temp = mp.PodajTemperature("warszawa","Kelvin");
                Console.WriteLine(temp);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nie udało się pobrać temperatury");
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();

        }
    }
}
