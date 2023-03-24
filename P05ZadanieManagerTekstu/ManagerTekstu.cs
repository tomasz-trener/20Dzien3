using P05ZadanieManagerTekstu.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05ZadanieManagerTekstu
{
    internal class ManagerTekstu
    {
        public string ZnajdzNajdluzszyWyraz(string zdanie)
        {
            if (zdanie.Length < 1)
                throw new ZbytKrotkieZdanieException();


            string[] wyrazy= zdanie.Split(' ');

            string aktualnieNajdluzszy = string.Empty;
            foreach (var w in wyrazy)
                if (w.Length > aktualnieNajdluzszy.Length)
                    aktualnieNajdluzszy = w;

            return aktualnieNajdluzszy;
        }

        public string[] ZnajdzWszystkieNajdluzszeWyrazy(string zdanie)
        {
            if (zdanie.Length < 1)
                throw new ZbytKrotkieZdanieException();

            string najdluzszy = ZnajdzNajdluzszyWyraz(zdanie);
            return znajdzWyrazyOPodanejDlugosci(najdluzszy.Length, zdanie);
        }

        private string[] znajdzWyrazyOPodanejDlugosci(int dlugosc, string zdanie)
        {
            List<string> znalezione = new List<string>();
            foreach (var w in zdanie.Split(' '))
                if (w.Length == dlugosc)
                    znalezione.Add(w);

            return znalezione.ToArray();
        }
    }
}
