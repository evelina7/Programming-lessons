using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Evelina";

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("|                            |");
            Console.Write("|        ");
            Console.Write("Mano vardas         |\n|           {0}", name);
            Console.WriteLine("          |        ");
            Console.WriteLine("|                            |");


            Console.WriteLine(new string('-', 30));
        }
    }
}
