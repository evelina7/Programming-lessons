using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Liepkite vartotojui įvesti bet kokį sveikąjį skaičių.
            // Išveskite šio skaičiaus daugybos lentelę nuo 1 iki 5.Pvz.:
            //2 * 1 = 2
            //…
            //2 * 5 = 10

            Console.WriteLine("1.");
            Console.Write("Įveskite bet kokį sveikąjį skaičių: ");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{skaicius} x 1 = {skaicius * 1}");
            Console.WriteLine($"{skaicius} x 2 = {skaicius * 2}");
            Console.WriteLine($"{skaicius} x 3 = {skaicius * 3}");
            Console.WriteLine($"{skaicius} x 4 = {skaicius * 4}");
            Console.WriteLine($"{skaicius} x 5 = {skaicius * 5}");
            Console.WriteLine("");

            //Liepkite vartotojui įvesti tris skaičius.
            //Į ekraną išveskite šiuos skaičius ir jų vidurkį. Pvz.:
            //Įvestų skaičių 4, 5, 8 vidurkis: 5,7.

            Console.WriteLine("2.");
            Console.WriteLine("Įveskite bet kokius tris skaičius: ");
            var skaicius1 = Convert.ToDouble(Console.ReadLine());
            var skaicius2 = Convert.ToDouble(Console.ReadLine());
            var skaicius3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Įvestų skaičių {skaicius1}, {skaicius2}, {skaicius3} vidurkis: {(skaicius1 + skaicius2 + skaicius3) / 3} ");
            Console.WriteLine("");

            //Liepkite įvesti tris skaičius.
            //Išveskite įvestus skaičius, jų kvadratus, juos pakeltus trečiuoju laipsniu,
            //taip pat tuos skaičius, padalintus iš dviejų.

            Console.WriteLine("3.");
            Console.WriteLine("Įveskite bet kokius tris skaičius: ");
            var skaicius_1 = Convert.ToDouble(Console.ReadLine());
            var skaicius_2 = Convert.ToDouble(Console.ReadLine());
            var skaicius_3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Įvesti skaičiai: {skaicius_1}, {skaicius_2}, {skaicius_3} ");
            Console.WriteLine($"Kiekvieno jų kvadratai: {Math.Pow(skaicius_1, 2)}, {Math.Pow(skaicius_2, 2)}, {Math.Pow(skaicius_3, 2)}");
            Console.WriteLine($"skaičiai, pakelti trečiuoju laipsniu: {Math.Pow(skaicius_1, 3)}, {Math.Pow(skaicius_2, 2)}, {Math.Pow(skaicius_3, 2)}");
            Console.WriteLine($"skaičiai, padalinti iš dviejų: {skaicius_1 / 2}, {skaicius_2 / 2}, {skaicius_3 / 2} ");
            Console.WriteLine("");
        }
    }
}
