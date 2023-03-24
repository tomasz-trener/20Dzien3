using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11ZadanieBiblioteka
{
    internal class Wypozyczenie
    {
        public Sygnatura Sygnatura { get; set; }
        public Czytelnik Czytelnik { get; set; }
        public DateTime DataWypozyczenia { get; set; }
        public DateTime DataPrzewidywanegoZwrotu { get; set; }
        public DateTime DataZwrotu { get; set; }
        public string Uwagi { get; set; }

        public Wypozyczenie Przedluzenie { get; set; }
    }
}
