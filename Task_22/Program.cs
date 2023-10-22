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
            Console.WriteLine($"Savaitės temperaturos rodmenys: {temperatura[0]}, {temperatura[1]}, {temperatura[2]}, {temperatura[3]}, {temperatura[4]}, {temperatura[5]}, {temperatura[6]}");
            Console.WriteLine($"žemiausia temperatūra: {min}");
            Console.WriteLine($"didžiausia temperatūra: {max}");
            Console.WriteLine($"Vidurkis yra: {vidurkis}");
            Console.WriteLine($"Temperatūrų, esančių žemiau už vidurkį, kiekis yra: {minSuma} / {minKiekis} = {minSuma / minKiekis}");
            Console.WriteLine($"Temperatūrų, esančių daugiau už vidurkį, kiekis yra: {maxSuma} / {maxKiekis} = {maxSuma / maxKiekis}");
            Console.WriteLine();

            //Susikurkite studentų pažymių masyvą. Raskite:
            //geriausią pažymį;
            //kiek mokinių yra gavę dešimtukus;
            //kiek mokinių yra gavę neigiamą pažymį(žemiau nei 4);
            //pažymių vidurkį.

            var pazymys = new int[] { 10,9,8,10,7 };
            var maxPazymys = pazymys.Max();
            var maxPazymysKiekis = 0;
            var minPazymysKiekis = 0;

            for (var i = 0; i < pazymys.Length; i++)
            {
                if (pazymys[i] == 10)
                {
                    maxPazymysKiekis++;
                }
            }

            for (var i = 0; i < pazymys.Length; i++)
            {
                if (pazymys[i] < 4)
                {
                    minPazymysKiekis++;
                }
            }
            
            Console.WriteLine("2.");
            Console.WriteLine($"Pažymiai: {pazymys[0]}, {pazymys[1]}, {pazymys[2]}, {pazymys[3]}, {pazymys[4]}");
            Console.WriteLine($"Geriausias pažymys: {maxPazymys}");
            Console.WriteLine($"Mokiniai, gavę dešimtukus: {maxPazymysKiekis}");
            Console.WriteLine($"Mokiniai, gavę neigiamą pažymį (žemiau nei 4): {minPazymysKiekis}");
            Console.WriteLine($"Visų pažymių vidurkį: {pazymys.Sum() / pazymys.Length}");
        }
    }
}
