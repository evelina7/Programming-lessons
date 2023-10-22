using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Paklausti vartotojo, kiek duomenų nori įvesti į masyvą
            //Pagal tai sukursime tokio dydžio masyvą
            //Iš konsolės įvesti duomenis į masyvą
            //Surasti 2 sumas:
            //Suma1 – kai masyvo elementas yra lyginis skaičius
            //Suma2 – kai masyvo indeksas nėra lyginis skaičius

            Console.Write("Kiek duomenų norite įvesti į masyvą? ");

            int kiekis = Convert.ToInt32(Console.ReadLine());
            var masyvas = new int[kiekis];
            int suma1 = 0;
            int suma2 = 0;  

            for (int i = 0; i < kiekis; i++) 
            {
                Console.Write("Įveskite skaičių: ");
                masyvas[i] = Convert.ToInt32(Console.ReadLine());

                if (masyvas[i] % 2 == 0)
                {
                    suma1 += masyvas[i];
                }
                else if (masyvas[i] % 2 != 0)
                { 
                    suma2 += masyvas[i];
                }
            }

            Console.WriteLine($"Lyginių skaičių suma: {suma1}");
            Console.WriteLine($"Nelyginių skaičių suma: {suma2}");
        }
    }
}
