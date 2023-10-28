using System;
using System.Text;

namespace Task_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Leiskite vartotojui įvesti du sveikuosius skaičius į programą.  Sukurkite ir panaudokite šiuos metodus:
            //Suma;
            //Skirtumas;
            //Sandauga;
            //Dalmuo;
            //Ne visai pagal užduotį. Skaičių įvedimas iš vartotojo turėtų vykti Main metode o skaičiavimai kiekvienas atskirame metode o ne visi kartu.

            Console.Write("Pirmasis skaičius: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Antrasis skaičius: ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            Suma(skaicius1, skaicius2);
            Skirtumas(skaicius1, skaicius2);
            Sandauga(skaicius1, skaicius2);
            Dalmuo(skaicius1, skaicius2);
        }

        private static void Suma(int skaicius1, int skaicius2)
        {
            Console.WriteLine($"Suma {skaicius1} + {skaicius2} = {skaicius1 + skaicius2}");
        }
        private static void Skirtumas(int skaicius1, int skaicius2)
        {
            Console.WriteLine($"Skirtumas {skaicius1} - {skaicius2} = {skaicius1 - skaicius2}");
        }
        private static void Sandauga(int skaicius1, int skaicius2)
        {
            Console.WriteLine($"Sandauga {skaicius1} * {skaicius2} = {skaicius1 * skaicius2}");
        }
        private static void Dalmuo(int skaicius1, int skaicius2)
        {
            Console.WriteLine($"Dalmuo {skaicius1} / {skaicius2} = {skaicius1 / skaicius2}");
        }
    }
}