using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Susikurti 2 masyvus su duomenimis, išbandant abu kūrimo būdus
            //(iškart su  duomenimis, arba pirma nusirodant dydį ir tada priskiriant reikšmes),
            //pasibandymui išsivesti norimus duomenis iš visų šių masyvų:
            //skirtą studentų pažymiams saugoti;
            //skirtą mašinų markėms saugoti.

            int[] pazymiai = { 10, 9, 7, 8, 10, 9 };
            Console.WriteLine(pazymiai[0]);
            Console.WriteLine(pazymiai[1]);
            Console.WriteLine(pazymiai[2]);
            Console.WriteLine(pazymiai[3]);
            Console.WriteLine(pazymiai[4]);
            Console.WriteLine(pazymiai[5]);
            Console.WriteLine();

            string[] markes = new string[3];
            markes[0] = "Audi";
            markes[1] = "Lexus";
            markes[2] = "KIA";

            Console.WriteLine(markes[0]);
            Console.WriteLine(markes[1]);
            Console.WriteLine(markes[2]);

            //Papildyti praeitos užduoties kodą.
            //Išvesti narių skaičių, pirmą narį ir paskutinį narį bent iš vieno pasirinkto masyvo.

            int paskutinisELementas = pazymiai[pazymiai.Length - 1];

            Console.WriteLine();
            Console.WriteLine(pazymiai.Length);
            Console.WriteLine("Pirmasis narys yra {0}", pazymiai[0]);
            Console.WriteLine("Paskutinysis narys yra {0}", paskutinisELementas);

        }
    }
}
