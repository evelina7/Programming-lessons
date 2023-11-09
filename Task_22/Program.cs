using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Susikurkite savaitės temperatūrų rodmenų masyvą.Raskite:
            //žemiausią temperatūrą;
            //didžiausią temperatūrą;
            //vidurkį;
            //Temperatūrų, esančių žemiau už vidurkį, kiekį;
            //Temperatūrų, esančių aukščiau už vidurkį, kiekį.

            var temperatura = new int[] {9,10,10,8,4,4,5};

            var min = temperatura.Min();
            var max = temperatura.Max();
            var suma = temperatura.Sum();
            var vidurkis = suma / temperatura.Length;
            var minSuma = 0;
            var minKiekis = 0;
            var maxSuma = 0;
            var maxKiekis = 0;

            for (var i = 0; i < temperatura.Length; i++)
            {
                if (temperatura[i] < vidurkis)
                {
                    minKiekis++;
                    minSuma += temperatura[i];
                }
            }

            for (var i = 0; i < temperatura.Length; i++) 
            { 
                if (temperatura[i] > vidurkis)
                {
                    maxKiekis++;
                    maxSuma += temperatura[i];
                }
            }

            Console.WriteLine("1.");
            Console.Write($"Savaitės temperaturos rodmenys: ");

            for (var i = 0; i < temperatura.Length; i++)
            {
                    Console.Write(temperatura[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine($"žemiausia temperatūra: {min}");
            Console.WriteLine($"didžiausia temperatūra: {max}");
            Console.WriteLine($"Vidurkis yra: {vidurkis}");
            Console.WriteLine($"Temperatūrų, esančių žemiau už vidurkį, kiekis yra: {minKiekis} ");
            Console.WriteLine($"Temperatūrų, esančių daugiau už vidurkį, kiekis yra:  {maxKiekis} ");
            Console.WriteLine();

            //Susikurkite studentų pažymių masyvą. Raskite:
            //geriausią pažymį;
            //kiek mokinių yra gavę dešimtukus;
            //kiek mokinių yra gavę neigiamą pažymį(žemiau nei 4);
            //pažymių vidurkį.

            var pazymiai = new int[] { 10,9,8,10,7 };
            var maxPazymys = pazymiai.Max();
            var destimtukuKiekis = 0;
            var neigiamuPazymiuKiekis = 0;

            for (var i = 0; i < pazymiai.Length; i++)
            {
                if (pazymiai[i] == 10)
                {
                    destimtukuKiekis++;
                }
                if (pazymiai[i] < 4)
                {
                    neigiamuPazymiuKiekis++;
                }
            }

            Console.WriteLine("2.");
            Console.Write($"Pažymiai: ");

            for (var i = 0; i < pazymiai.Length; i++)
            {
                Console.Write(pazymiai[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine($"Geriausias pažymys: {maxPazymys}");
            Console.WriteLine($"Mokiniai, gavę dešimtukus: {destimtukuKiekis}");
            Console.WriteLine($"Mokiniai, gavę neigiamą pažymį (žemiau nei 4): {neigiamuPazymiuKiekis}");
            Console.WriteLine($"Visų pažymių vidurkį: {pazymiai.Sum() / pazymiai.Length}");
        }
    }
}
