using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P01TypyZmiennych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            char b = 'a';
            string c = "hej";
            double d = 6.5;
            bool e = false;

            
            int a2 = a; // struktury przeknazywane są przez kopie 
            a = 7;
            //a2= 6


            WebClient wc = new WebClient();
            DateTime dt = new DateTime();
            DateTime dt2 = new DateTime(2000, 3, 2);

            StringBuilder sb = new StringBuilder();
            sb.Append("ala ");
            sb.Append("ma ");
            sb.Append("kota");
            string s = sb.ToString();

            StringBuilder sb2 = sb; // klasy przekazywane są przez referencje 
            sb2.Append(" i psa");
        }
    }
}
