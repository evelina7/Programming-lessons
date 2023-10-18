using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            /*
             Išveskite pasirinkto skaičiaus daugybos lentelę. 
            Pvz.: 5 * 0 = 0 
            5 * 1 = 5
            …
            5 * 10 = 50
            */

            var skaicius = 7;
            var daugiklis = 1;
            var result1 = skaicius * daugiklis;
            var result2 = skaicius * ++daugiklis;
            var result3 = skaicius * ++daugiklis;
            var result4 = skaicius * ++daugiklis;
            var result5 = skaicius * ++daugiklis;
            var result6 = skaicius * ++daugiklis;
            var result7 = skaicius * ++daugiklis;
            var result8 = skaicius * ++daugiklis;
            var result9 = skaicius * ++daugiklis;
            var result10 = skaicius * ++daugiklis;

            Console.WriteLine("{0} x {1} = {2}", skaicius, 1, result1);
            Console.WriteLine("{0} x {1} = {2}", skaicius, 2, result2);
            Console.WriteLine("{0} x {1} = {2}", skaicius, 3, result3);
            Console.WriteLine("{0} x {1} = {2}", skaicius, 4, result4);
            Console.WriteLine("{0} x {1} = {2}", skaicius, 5, result5);
            Console.WriteLine("{0} x {1} = {2}", skaicius, 6, result6);
            Console.WriteLine("{0} x {1} = {2}", skaicius, 7, result7);
            Console.WriteLine("{0} x {1} = {2}", skaicius, 8, result8);
            Console.WriteLine("{0} x {1} = {2}", skaicius, 9, result9);
            Console.WriteLine("{0} x {1} = {2}", skaicius, 10, result10);
            Console.WriteLine("");

            /*
            Susikurkite sveikojo skaičiaus kintamąjį su dviženklio 
            skaičiaus reikšme. Išveskite į ekraną šio skaičiaus 
            skaitmenų sandaugą.
            */
        }
    }
}
