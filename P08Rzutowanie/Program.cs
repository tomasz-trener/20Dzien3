using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08Rzutowanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "4";
            int a = Convert.ToInt32(s);


            bool czyUdaloSie= int.TryParse(s, out int x);



            int b = 5;
            double c = (double)b;



            double? d = (double?)5.0;

            if (d != null)
            {
                double d2 = (double)d;
            }




            







        }
    }
}
