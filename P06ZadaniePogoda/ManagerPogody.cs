using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P06ZadaniePogoda
{
    internal class ManagerPogody
    {
        public double PodajTemperature(string miasto, string jednostka)
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

        private double transformujTemperature(string jednostka, double temp)
        {
            if (jednostka == "Celcjusz")
                return temp;

            if (jednostka == "Farenheit")
                return (temp*1.8)+32;


            if (jednostka == "Kelvin")
                return temp+273.15;

            throw new Exception("Nieznana jednostka");
        }
    }
}
