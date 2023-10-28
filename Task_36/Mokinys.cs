using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_36
{
    internal class Mokinys
    {

        //Sukurti klasę Mokinys su kintamaisiais: vardas, pavardė, amžius, klasė ir  pažymių sąrašą, kur saugosime 5 pažymius.
        //Sukurti konstruktorių, kad priskirtų reikšmes.
        //Klasės viduje sukurti metodą, kad išvestų visą informaciją apie mokinį.
        //Susikurti 3 objektus, jiems priskirti reikšmes ir naudojant sukurtą metodą išvesti kiekvieno mokinio informaciją.

        public string Vardas;
        public string Pavarde;
        public int Amzius;
        public string Klase;
        public List<int> PazymiuSarasas;

        public Mokinys(string vardas, string pavarde, int amzius, string klase, List<int> pazymiuSarasas)
        {
            //konstruktorius
            Vardas = vardas;
            Pavarde = pavarde;
            Amzius = amzius;
            Klase = klase;
            PazymiuSarasas = pazymiuSarasas;
        }

        //metodas
        public void MokinioInformacija()
        {
            Console.Write($"Mokinys {Vardas} {Pavarde}, amžius - {Amzius}, klasė - {Klase}. Pažymių sąrašas: ");

            for (int i = 0; i < PazymiuSarasas.Count; i++)
            {
                Console.Write(PazymiuSarasas[i] + " ");
            }
            Console.WriteLine();
        }
    }
}