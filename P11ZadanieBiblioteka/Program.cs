using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11ZadanieBiblioteka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Karta k = new Karta()
            {
                Tytul = "O kurdlach dla opornych",
                NrKarty = "1308/00",
                Wydanie = 1,
                DataZakupu = new DateTime(2000, 1, 27),
                Cena = new Cena(),
                Autorzy = new List<Autor>()
                {
                    new Autor()
                    {
                        Imie = "L",
                        Nazwisko = "Tarantoga",
                        DrugieImie = "A"
                    },
                    new Autor()
                    {
                        Imie = "I",
                        Nazwisko = "Tichy",
                    },
                },
                Sygnatury = new List<Sygnatura>()
                {
                    new Sygnatura()
                    {
                        Aktywna = false,
                        Komentarz =" (zgłoszona utrata 01.05.2000)",
                        NrSygnatury = 012371,
                        Wypozyczenia = new List<Wypozyczenie>()
                        {
                            new Wypozyczenie()
                            {
                                DataWypozyczenia = new DateTime(2000,2,22),
                                DataPrzewidywanegoZwrotu = new DateTime(2000,3,7),
                                Uwagi = "06.03.2000 Zgoda na przedłużenie",
                                Przedluzenie = new Wypozyczenie()
                                {
                                    DataPrzewidywanegoZwrotu = new DateTime(2000,3,15),
                                    DataZwrotu = new DateTime(2000,3,15)
                                }
                            }
                        }
                    }
                }
            };

            k.Cena.Komentarz = "xx";

            string s = k.Sygnatury[0].Wypozyczenia[0].Uwagi;
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
