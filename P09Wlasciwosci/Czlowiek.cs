using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09Wlasciwosci
{
    internal class Czlowiek
    {
        private string imie;
        private string nazwisko;

        public string Imie { get; set; } // właściwość 
        public string Nazwisko { get; set; } // właściwość 

        private int wzrost; //pole

        public string ImieNazwisko // właściwość 
        {
            get
            {
                string s1 = imie.ToUpper();
                string s2 = nazwisko.ToLower();

                return s1 + " " + s2;
            }
            set
            {
                string przychodzacaWartosc = value;
                string[] s= przychodzacaWartosc.Split(' ');
                imie = s[0];
                nazwisko = s[1];
            }
        }

        

    }
}
