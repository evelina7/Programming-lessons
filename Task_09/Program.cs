using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Liepkite vartotojui įvesti savo amžių.
            //Jei amžius yra 18 arba daugiau, tuomet į ekraną išveskite, kad “jūs galite balsuoti”.

            Console.WriteLine("1.");
            Console.Write("Įveskite savo amžių: ");
            var amzius = Convert.ToInt32(Console.ReadLine());

            if (amzius >= 18) {

                Console.WriteLine("Jūs galite balsuoti.");
            }
            
            Console.WriteLine("");

            //Liepkite vartotojui įvesti bet kokį skaičių. Parašykite šias atskiras if sąlygas:
            //Patikrinti, ar skaičius neigiamas, jei taip -aprėkti vartotoją:)
            //Patikrinti, ar skaičius teigiamas, jei taip -pasveikinti vartotoją;
            //Patikrinti, ar skaičius lyginis, jei taip -išvesti “taip, skaičius yra lyginis”;
            //Patikrinti, ar skaičius dalinasi iš 4, jei taip -išvesti “taip, dalinasi iš 4”;
            //Patikrinti, ar skaičius yra didesnis nei 10, jei taip -išvesti “taip, skaičius yra didesnis už 10”.

            Console.WriteLine("2.");

            Console.Write("Įveskite bet kokį skaičių: ");
            var skaicius = Convert.ToDouble(Console.ReadLine());

            if (skaicius < 0)
            {
                Console.WriteLine(" (>_<) !!!!!!!");
            }
            if (skaicius > 0)
            {
                Console.WriteLine("Sveiki! :)");
            }
            if (skaicius % 2 == 0)
            {
                Console.WriteLine("Taip, skaičius yra lyginis.");
            }
            if (skaicius % 4 == 0)
            {
                Console.WriteLine("Taip, skaičius dalinasi iš 4.");
            }
            if (skaicius > 10)
            {
                Console.WriteLine("Taip, skaičius yra didesnis už 10.");
            }

            Console.WriteLine("");

            //Liepkite vartotojui įvesti du savo pažymius,
            //raskite šių pažymių vidurkį, patikrinkite, ar vidurkis
            //yra lygus arba didesnis už 5, jei taip, išveskite “Valio!!!”.

            Console.WriteLine("3.");

            Console.WriteLine("Įveskite du savo pažymius: ");
            var pazymys1 = Convert.ToInt32(Console.ReadLine());
            var pazymys2 = Convert.ToInt32(Console.ReadLine());
            var vidurkis = (pazymys1 + pazymys2) / 2;

            if (vidurkis >= 5)
            {
                Console.WriteLine("Valio!!!");
            }

            Console.WriteLine("");
        }
    }
}
