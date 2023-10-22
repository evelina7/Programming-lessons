using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Sugeneruokite atsitiktinio dydžio sąrašą, kurį užpildykite atsitiktiniais  skaičiais nuo 1 iki 100.Raskite:
            //mažiausią skaičių;
            //didžiausią skaičių;
            //vidurkį;
            //kiek skaičių yra žemesni už vidurkį;
            //lyginių skaičių sumą;

            Console.WriteLine("1. Užduotis");

            List<double> listSkaiciai = new List<double> { 9, 10, 85, 84.5, 30, 11.5, 77, 17, 27, 99 };

            double minKiekis = 0;
            double suma = 0;
            double vidurkis = listSkaiciai.Average();

            foreach (double skaicius in listSkaiciai) 
            { 
                Console.WriteLine(skaicius);

                if (skaicius < vidurkis)
                {
                    minKiekis++;
                }

                if (skaicius % 2 == 0)
                {
                    suma += skaicius;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Mažiausias skaičius: " + listSkaiciai.Min());
            Console.WriteLine($"Didžiausias skaičius: " + listSkaiciai.Max());
            Console.WriteLine($"Vidurkis: {vidurkis}");
            Console.WriteLine($"Skaičiai, žemesni už vidurkį (kiekis): {minKiekis}");
            Console.WriteLine($"Lyginių skaičių suma: {suma}");
            Console.WriteLine();

            //Liepkite vartotojui pasirinkti kiek studentų pažymių nori suvesti į sąrašą.
            //Tegul jis užpildo šį sąrašą duomenimis, įvedant juos per konsolę. Raskite:
            //didžiausią pažymį;
            //mažiausią pažymį;
            //vidurkį;

            Console.WriteLine("2. Užduotis");
            Console.Write("Įveskite pažymių kiekį: ");
            int kiekis = Convert.ToInt32(Console.ReadLine());

            List<int> listPazymiai = new List<int>();

            for (int i = 0; i < kiekis; i++)
            {
                Console.Write("Įveskite pažymį: ");
                listPazymiai.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine($"Mažiausias pažymys: " + listPazymiai.Min());
            Console.WriteLine($"Didžiausias pažymys: " + listPazymiai.Max());
            Console.WriteLine($"Vidurkis: " + listPazymiai.Average());

        }
    }
}
