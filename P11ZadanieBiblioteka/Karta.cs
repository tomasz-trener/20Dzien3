using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11ZadanieBiblioteka
{
    internal class Karta
    {
        public int Wydanie { get; set; }
        public DateTime DataZakupu { get; set; }
        public Cena Cena { get; set; }
        public string Tytul { get; set; }
        public List<Sygnatura> Sygnatury { get; set; }
        public List<Autor> Autorzy { get; set; }
        public Karta Nastepna { get; set; }
        public Karta Poprzednia { get; set; }
        public string NrKarty { get; set; }
    }
}
