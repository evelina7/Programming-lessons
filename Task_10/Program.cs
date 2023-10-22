using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Liepkite įvesti skaičių.
            //Jei skaičius lyginis, tuomet išveskite šį skaičių bei jo penktą laipsnį.
            //Jei skaičius nesidalina iš 4, tuomet liepkite įvesti antrąjį skaičių.
            //Išveskite abiejų skaičių sumą ir sandaugą.

            Console.Write("Įveskite bet kokį skaičių: ");
            var skaicius = Convert.ToDouble(Console.ReadLine());

            if (skaicius % 2 == 0)
            {
                Console.WriteLine($"Įvestas skaičius: {skaicius} ir jo penktasis laipsnis: {Math.Pow(skaicius, 5)}");
            }
            if (skaicius % 4 != 0)
            {
                Console.Write("Įveskite bet kokį antrąjį skaičių: ");
                var skaicius2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Skaičių {skaicius} ir {skaicius2} suma: {skaicius + skaicius2} ");
                Console.WriteLine($"Skaičių {skaicius} ir {skaicius2} sandauga: {skaicius * skaicius2} ");
            }
        }
    }
}
