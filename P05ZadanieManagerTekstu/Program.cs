using P05ZadanieManagerTekstu.Exceptions;
using System;

namespace P05ZadanieManagerTekstu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj zdanie");
            string zdanie = Console.ReadLine();

            ManagerTekstu mt = new ManagerTekstu();

            try
            {
                string najdluzszy = mt.ZnajdzNajdluzszyWyraz(zdanie);
                Console.WriteLine("Pierwszy najdluzszy wyraz: " + najdluzszy);

                string[] wyrazy = mt.ZnajdzWszystkieNajdluzszeWyrazy(zdanie);
                Console.WriteLine("Wszystkie najdluzsze wyrazy: " + string.Join(", ", wyrazy));
            }
            catch (ZbytKrotkieZdanieException)
            {
                Console.WriteLine("Zdanie zbyt krótkie");
            }
            catch (Exception)
            {
                Console.WriteLine("Nieznany bład");
            }

            

            Console.ReadKey();
        }
    }
}
