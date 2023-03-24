using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02WlasneKlasy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kalkulator k = new Kalkulator();

            Kalkulator k; //deklaruje zmienną o nazwie 'k'
                          // typu kalkulator. 
                          // ta zmienna jest gotowa na to aby do niej 
                          // przypisać nowy obiekt typu Kalkulator 

            k = new Kalkulator();

            Kalkulator k2 = new Kalkulator();
            // tworze nowa zmienna i do niej przypisuje nowa instacje klasy 
            // kalkulator (nowy obiekt typu kalkulator) 


            new Kalkulator(); // tworzymy nowa instacje kalkulatora 
            // w pamieci ten obiekt jest ale nie ma do niego uchwytu w postaci zminnej 

            Kalkulator k3 = k;
        }
    }
}
