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

            var suma = a + b;
            var skirtumas = a - b;
            var sandauga = a * b;
            var dalyba = a / b;
            var kvadratas = b * b;
            var treciasis_laipsnis = b * b * b;
            var visu_sandauga = a * b * c;

            Console.WriteLine("1. ");
            Console.WriteLine("Suma: {0} + {1} = {2} ", a, b,suma);
            Console.WriteLine("Skirtumas: {0} - {1} = {2} ", a, b, skirtumas);
            Console.WriteLine("Sandauga: {0} * {1} = {2} ", a, b, sandauga);
            Console.WriteLine("Dalyba: {0} / {1} = {2} ", a, b, dalyba);
            Console.WriteLine();

            /*
             Išveskite į ekraną pasirinktą skaičių, jo kvadratą ir jį 
            pakeltą trečiuoju laipsniu.
             */

            Console.WriteLine("2. ");
            Console.WriteLine("Skaičius: {0}", b);
            Console.WriteLine("Skaičiaus kvadratas: {0}", kvadratas);
            Console.WriteLine("Skaičius pakeltas trečiuoju laipsniu: {0}", treciasis_laipsnis);
            Console.WriteLine();

            /*
             Išveskite į ekraną trijų skaičių sandaugą.
             */

            Console.WriteLine("3. ");
            Console.WriteLine("Skaičiai: {0}, {1}, {2}", a,b,c);
            Console.WriteLine("Skaičių sandauga: {0}", visu_sandauga);

        }
    }
}
