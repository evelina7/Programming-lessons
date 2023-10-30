using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Liepkite vartotojui įvesti tris skaičius.Su switch patikrinkite pirmąjį skaičių:
            //ar jis lygus 1: išveskite visų trijų skaičių sumą;
            //ar jis lygus 2: išveskite pirmo ir trečio skaičių skirtumą;
            //ar jis lygus 3: išveskite antro ir trečio skaičių sandaugą.

            Console.WriteLine("Įveskite bet kokius tris skaičius: ");
            var skaicius1 = Convert.ToInt32(Console.ReadLine());
            var skaicius2 = Convert.ToInt32(Console.ReadLine());
            var skaicius3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (skaicius1)
            {
                case 1:
                    Console.WriteLine($"{skaicius1 + skaicius2 + skaicius3}");
                    break;
                case 2:
                    Console.WriteLine($"{skaicius1 - skaicius3}");
                    break;
                case 3:
                    Console.WriteLine($"{skaicius2 * skaicius3}");
                    break;
            }
            Console.WriteLine();

            //Liepkite vartotojui įvesti gyvūno rūšį.Su switch patikrinkite:
            //ar įvestas gyvūnas yra šuo;
            //ar įvestas gyvūnas yra katė;
            //ar įvestas gyvūnas yra žiurkėnas.

            Console.WriteLine("2.");
            Console.WriteLine("Įveskite gyvūno rūšį: ");
            string gyvunas = Console.ReadLine();
            Console.WriteLine();

            switch (gyvunas)
            {
                case "suo":                    
                    Console.WriteLine("šuo");
                    break;
                case "kate":
                    Console.WriteLine("katė");
                    break;
                case "ziurkenas":
                    Console.WriteLine("žiurkėnas");
                    break;
            }
            Console.WriteLine();
        }
    }
}
