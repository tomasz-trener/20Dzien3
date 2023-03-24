using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieKalkulator
{
    internal class Kalkulator
    {
        public double WykonajDzialanie(int a, int b, char znak)
        {
            string op = znak.ToString();
            int liczba1 = a;
            int liczba2 = b;

            return wykonajDzialanie(liczba1, liczba2, op);
        }


        public double WykonajDzialanie(string rownanie)
        {
            string op = rownanie.Substring(1, 1);
            int liczba1 = Convert.ToInt32(rownanie.Substring(0, 1));
            int liczba2 = Convert.ToInt32(rownanie.Substring(2));

            return wykonajDzialanie(liczba1, liczba2, op);
        }

        private double wykonajDzialanie(int liczba1, int liczba2, string op)
        {
            double? wynik = null;
            // string s = null;

            if (!(liczba2 == 0 && op == "/"))
            {
                if (op == "+")
                    wynik = liczba1 + liczba2;
                else if (op == "-")
                    wynik = liczba1 - liczba2;
                else if (op == "*")
                    wynik = liczba1 * liczba2;
                else if (op == "/")
                    wynik = Convert.ToDouble(liczba1) / liczba2;
                else
                    throw new Exception("nieznany operator");
            }
            else
                throw new Exception("próba dzielenia przez 0");

            if (wynik != null)
                return (double)wynik;
            else
                throw new Exception("Nieczekiawny bład podczas obliczania wyniku");   // return 0;
        }
    }
}
