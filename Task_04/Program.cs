using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var marke = "Audi";
            var modelis = "Q3";
            var metai = 2022;
            var rida = 10000;

            Console.WriteLine("Automobilio {0} {1} ({2} m.) rida - {3} km." , marke,modelis,metai,rida);

        }
    }
}
