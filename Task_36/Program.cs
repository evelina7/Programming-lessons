using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Task_36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            //Sukurti klasę Mokinys su kintamaisiais: vardas, pavardė, amžius, klasė ir  pažymių sąrašą, kur saugosime 5 pažymius.
            //Sukurti konstruktorių, kad priskirtų reikšmes.
            //Klasės viduje sukurti metodą, kad išvestų visą informaciją apie mokinį.
            //Susikurti 3 objektus, jiems priskirti reikšmes ir naudojant sukurtą metodą išvesti kiekvieno mokinio informaciją.

            // klasės objektai
            Mokinys mokinysTomas = new Mokinys("Tomas", "Tomasas", 14, "7a", new List<int> {10,8,9,7,8});
            Mokinys mokinysJonas = new Mokinys("Jonas", "Jonaitis", 15, "8c", new List<int> { 5, 8, 7, 6, 6 });
            Mokinys mokinysAndrius = new Mokinys("Andrius", "Andriauskas", 16, "9a", new List<int> { 6, 8, 9, 7, 8 });

            mokinysTomas.MokinioInformacija();
            mokinysJonas.MokinioInformacija();
            mokinysAndrius.MokinioInformacija();

        }
    }
}
