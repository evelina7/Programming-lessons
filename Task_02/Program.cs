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
            Console.Write("|");
            Console.Write(new string(' ', 28));
            Console.WriteLine("|");
            Console.Write("|");
            Console.Write(new string(' ', 9));
            Console.Write("Mano vardas");
            Console.Write(new string(' ', 8));
            Console.WriteLine("|");
            Console.Write("|");
            Console.Write(new string(' ', 11));
            Console.Write("{0}", name);
            Console.Write(new string(' ', 10));
            Console.WriteLine("|");
            Console.Write("|");
            Console.Write(new string(' ', 28));
            Console.WriteLine("|");
            Console.WriteLine(new string('-', 30));
        }
    }
}
