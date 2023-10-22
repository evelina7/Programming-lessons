using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Paprašyti įvesti vartotojo vardą.
            //Sukurti string tipo metodą, kuris gražina frazę pvz „Sveiki, Mantas“.
            //Išvesti šią frazę į konsolę.

            Console.Write("Įveskite savo vardą: ");
            string ivestasVardas = Console.ReadLine();
            Program p = new Program();
            var result = p.Vardas(ivestasVardas);
            Console.WriteLine($"Sveiki, {result}!");
            Console.WriteLine();
        }
        private string Vardas(string vardas)
        {
            return vardas;
        }
    }
}
