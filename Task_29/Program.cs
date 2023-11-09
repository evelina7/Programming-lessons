using System;
using System.Text;
using System.Threading.Tasks;

namespace Task_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Parašykite metodą, kuris pasisveikintų su vartotoju.
            //Vartotojas turi įvesti savo vardą, amžių ir hobio pavadinimą.
            //Visi šie duomenys yra duodami metodui, kuris visą šią informaciją išveda
            //formatuotai

            Console.Write("Jūsų vardas: ");
            string vardas = Console.ReadLine();
            Console.Write("Jūsų amžius: ");
            int amzius = Convert.ToInt32(Console.ReadLine());
            Console.Write("Jūsų hobis: ");
            string hobis = Console.ReadLine();

            Pasisveikinimas(vardas, amzius, hobis);
        }

        internal static void Pasisveikinimas(string vardas, int amzius, string hobis)
        {
            Console.WriteLine($"Labas, {vardas}! ({amzius}) m.");
            Console.WriteLine($"Jūsų hobis: {hobis}"); 

        }
    }
}