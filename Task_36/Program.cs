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

            //Klasės viduje sukurti void tipo metodą, kuris išvestų į ekraną už, kiek metų  mokinys baigs mokyklą,
            //jei atsakymas 0 – tuomet išvesti „Mokinys mokyklą  baigs šiais metais“. Iškviesti metodą Main‘o viduje visiems objektams.

            //Main‘o viduje naudojant Sąrašo komandas Max() ir Min() išvesti į ekraną
            //kiekvieno mokinio geriausią ir blogiausią pažymį.

            //Sukurti int tipo metodą(pagrindinės klasės viduje), kuriam paduosim kintamąjį, kurio tipas yra Mokinys.
            //Metodas turi apskaičiuoti, kiek yra mokinio pažymių, didesnių už 4.Išvesti šią informaciją apie kiekvieną mokinį.

            Mokinys mokinysTomas = new Mokinys("Tomas", "Tomasas", 14, "7a", new List<int> { 10, 8, 9, 7, 8 });
            Mokinys mokinysJonas = new Mokinys("Jonas", "Jonaitis", 15, "8c", new List<int> { 5, 8, 7, 6, 6 });
            Mokinys mokinysAndrius = new Mokinys("Andrius", "Andriauskas", 16, "9a", new List<int> { 6, 8, 3, 7, 8 });

            mokinysTomas.MokinioInformacija();
            Console.WriteLine($"Mažiausias pažymys: " + mokinysTomas.PazymiuSarasas.Min());
            Console.WriteLine($"Mažiausias pažymys: " + mokinysTomas.PazymiuSarasas.Max());
            mokinysTomas.LikoMetuMokytis();
            Console.WriteLine($"Mokinio {mokinysTomas} teigiamų pažymių kiekis: {GautiPazymiuKieki(mokinysTomas)}");
            Console.WriteLine();

            mokinysJonas.MokinioInformacija();
            Console.WriteLine($"Mažiausias pažymys: " + mokinysJonas.PazymiuSarasas.Min());
            Console.WriteLine($"Mažiausias pažymys: " + mokinysJonas.PazymiuSarasas.Max());
            mokinysJonas.LikoMetuMokytis();
            Console.WriteLine($"Mokinio {mokinysTomas} teigiamų pažymių kiekis: {GautiPazymiuKieki(mokinysJonas)}");
            Console.WriteLine();

            mokinysAndrius.MokinioInformacija();
            Console.WriteLine($"Mažiausias pažymys: " + mokinysAndrius.PazymiuSarasas.Min());
            Console.WriteLine($"Mažiausias pažymys: " + mokinysAndrius.PazymiuSarasas.Max());
            mokinysAndrius.LikoMetuMokytis();
            Console.WriteLine($"Mokinio {mokinysTomas} teigiamų pažymių kiekis: {GautiPazymiuKieki(mokinysAndrius)}");
            Console.WriteLine();
        }

        //Sukurti int tipo metodą(pagrindinės klasės viduje), kuriam paduosim kintamąjį, kurio tipas yra Mokinys.
        //Metodas turi apskaičiuoti, kiek yra mokinio pažymių, didesnių už 4.Išvesti šią informaciją apie kiekvieną mokinį.

        public static int GautiPazymiuKieki(Mokinys mokinys)
        {
            int kiekis = 0;

            foreach (int pazymys in mokinys.PazymiuSarasas)
            {
                if (pazymys > 4)
                {
                    kiekis++;
                }
            }
            return kiekis;
        }
    }
}

