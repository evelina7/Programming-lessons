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

            Skaiciuokle();
        }
        private static void Skaiciuokle()
        {
            Console.Write("Pirmasis skaičius: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Antrasis skaičius: ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Suma {skaicius1} + {skaicius2} = {skaicius1 + skaicius2}");
            Console.WriteLine($"Skirtumas {skaicius1} - {skaicius2} = {skaicius1 - skaicius2}");
            Console.WriteLine($"Sandauga {skaicius1} * {skaicius2} = {skaicius1 * skaicius2}");
            Console.WriteLine($"Dalmuo {skaicius1} / {skaicius2} = {skaicius1 / skaicius2}");

        }
    }
}