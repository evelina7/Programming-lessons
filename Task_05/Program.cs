using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /*
             Išveskite į ekraną dviejų skaičių sumą, skirtumą, 
            sandaugą ir dalmenį, kiekvieną kartą nurodant atliekamą 
            veiksmą ir šių skaičių reikšmes. Pvz.: 4 + 5 = 9 4 - 5 = -1
             */

            var a = 10;
            var b = 2;
            var c = 4;

            var kvadratas = b * b;
            var treciasis_laipsnis = b * b * b;
            var visu_sandauga = a * b * c;

            Console.WriteLine("1. ");
            Console.WriteLine($"Suma: {a} + {b} = {a+b} ");
            Console.WriteLine($"Skirtumas: {a} - {b} = {a - b} ");
            Console.WriteLine($"Sandauga: {a} * {b} = {a * b} ");
            Console.WriteLine($"Dalyba: {a} / {b} = {a / b} ");
            Console.WriteLine();

            /*
             Išveskite į ekraną pasirinktą skaičių, jo kvadratą ir jį 
            pakeltą trečiuoju laipsniu.
             */

            Console.WriteLine("2. ");
            Console.WriteLine("Skaičius: {0}", b);
            Console.WriteLine($"Skaičiaus kvadratas: {b*b}");
            Console.WriteLine($"Skaičius pakeltas trečiuoju laipsniu: {b*b*b}");
            Console.WriteLine();

            /*
             Išveskite į ekraną trijų skaičių sandaugą.
             */

            Console.WriteLine("3. ");
            Console.WriteLine("Skaičiai: {0}, {1}, {2}", a,b,c);
            Console.WriteLine($"Skaičių sandauga: {a*b*c}");

        }
    }
}
