using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P10Konstruktory
{
    enum Jednostka
    {
        Celsjusz,
        Kelvin,
        Fahrenheit
    }


    internal class ManagerPogody
    {
        public string SzukanyZnak { get;  }// = "°";
        public string ZnakKoncowy { get; set; } = ">"; // właściwość 

        private const string adresSerwisu = "https://www.google.com/search"; //pole

        private Jednostka jednostka;

        public string AdresSerwisu => adresSerwisu;
        //public string AdresSerwisu
        //{
        //    get
        //    {
        //        return adresSerwisu;
        //    }
        //}
        public ManagerPogody()
        {
            
        }

        public ManagerPogody(Jednostka jednostka)
        {
            this.jednostka = jednostka;
            SzukanyZnak = "°"; // domyslna wartość
        }

        public double PodajTemperature(string miasto)
        {
            string adres = adresSerwisu + "?q=pogoda " + miasto;

            WebClient wc = new WebClient();
            string dane = wc.DownloadString(adres);

            try
            {
                int indx = dane.IndexOf(SzukanyZnak);
                int aktualnaPozycja = indx;
                int liczbaIteracji = 0;

                while (dane.Substring(aktualnaPozycja, 1) != ZnakKoncowy)
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
