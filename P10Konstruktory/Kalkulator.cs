using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10Konstruktory
{
    internal class Kalkulator
    {

        private string tryb; 

        public string Tryb
        {
            get { return tryb; }
            set { tryb = value; }
        }


        public Kalkulator(string tryb)
        {
            string s = "x";

            this.tryb = tryb + s;
        }


        public double Policz(int a, int b)
        {
            if (tryb == "normlany")
            {
                return a + b;
            }

            if (tryb == "naukowy")
            {
                return a + b;
            }

            throw new Exception();
        }


    }
}
