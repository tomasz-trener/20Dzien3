using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P07Enumeratory
{
    enum Jednostka
    {
        Celsjusz,
        Kelvin,
        Fahrenheit
    }


    internal class ManagerPogody
    {
        public double PodajTemperature(string miasto, Jednostka jednostka)
        {
            string szukanyZnak = "°";
            string znakKoncowy = ">";

            string adres = $"https://www.google.com/search?q=pogoda {miasto}";

            WebClient wc = new WebClient();
            string dane = wc.DownloadString(adres);

            try
            {
                int indx = dane.IndexOf(szukanyZnak);
                int aktualnaPozycja = indx;
                int liczbaIteracji = 0;

                while (dane.Substring(aktualnaPozycja, 1) != znakKoncowy)
                {
                    liczbaIteracji++;
                    aktualnaPozycja--;
                    if (liczbaIteracji > 4)
                        throw new Exception();
                }

                string wynik = dane.Substring(aktualnaPozycja + 1, indx - aktualnaPozycja + 1);

                double skonwertowanyWynik = transformujTemperature(
                                                jednostka,
                                                Convert.ToInt32(wynik.Substring(0, wynik.Length - 2)));
                return skonwertowanyWynik;
           
            }
            catch (Exception)
            {
                throw;   
            }
        }

        private double transformujTemperature(Jednostka jednostka, double temp)
        {
            if (jednostka == Jednostka.Celsjusz)
                return temp;

            if (jednostka == Jednostka.Fahrenheit)
                return (temp*1.8)+32;


            if (jednostka == Jednostka.Kelvin)
                return temp+273.15;

            throw new Exception("Nieznana jednostka");
        }
    }
}
