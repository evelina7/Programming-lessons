using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Įvesti du skaičius iš konsolės

            //Paklausti vartotojo kokį veiksmą su tais skaičiais nori atlikti:
            //sudėtis, atimtis,  kėlimas 4 laipsniu sudėjus abu skaičius, kvadratinė šaknis sudėjus abu skaičius.

            //Parašyti po atskirą metodą kiekvienam veiksmui(sudėčiai ir atimčiai naudoti  int tipą, o visiems kitiems double).

            //Su switch () patikrinti kokį veiksmą atlikti ir kiekviename case‘e išsikviesti  atitinkamą metodą,
            //jei tokio case‘o nėra – informuoti vartotoją, jog tokio veiksmo nėra.

            Console.WriteLine("Įveskite du skaičius: ");
            int ivestasSkaicius1 = Convert.ToInt32(Console.ReadLine());
            int ivestasSkaicius2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pasirinkite, kokį veiksmą norite atlikti su šiais skaičiais: ");
            Console.WriteLine("1 - jei sudėtis ");
            Console.WriteLine("2 - jei atimtis ");
            Console.WriteLine("3 - jei kėlimas 4 laipsniu sudėjus abu skaičius");
            Console.WriteLine("4 - jei kvadratinė šaknis sudėjus abu skaičius");
            int veiksmas = Convert.ToInt32(Console.ReadLine());

            switch (veiksmas)
            {
                case 1:
                    Program sudetis = new Program();
                    var resultSudetis = sudetis.Sudetis(ivestasSkaicius1, ivestasSkaicius2);
                    Console.WriteLine($"Atsakymas: {resultSudetis}");
                    Console.WriteLine();
                    break;
                case 2:
                    Program atimtis = new Program();
                    var resultAtimtis = atimtis.Atimtis(ivestasSkaicius1, ivestasSkaicius2);
                    Console.WriteLine($"Atsakymas: {resultAtimtis}");
                    Console.WriteLine();
                    break;
                case 3:
                    Program kelimasKetvirtuoju = new Program();
                    var resultKelimasKetvirtuoju = kelimasKetvirtuoju.KelimasKetvirtuoju(ivestasSkaicius1, ivestasSkaicius2);
                    Console.WriteLine($"Atsakymas: {resultKelimasKetvirtuoju}");
                    Console.WriteLine();
                    break;
                case 4:
                    Program kvadratineSaknis = new Program();
                    var resultKvadratineSaknis = kvadratineSaknis.KvadratineSaknis(ivestasSkaicius1, ivestasSkaicius2);
                    Console.WriteLine($"Atsakymas: {resultKvadratineSaknis}");
                    break;
                    default:
                    Console.WriteLine("Tokio veiksmo nėra.");
                    break;
            }
            Console.WriteLine();
        }
        private int Sudetis(int a1, int a2)
        {
            return a1 + a2;
        }
        private int Atimtis(int b1, int b2)
        {
            return b1 - b2;
        }
        private double KelimasKetvirtuoju(double c1, double c2)
        {
            return Math.Pow((c1 + c2), 4);  
        }
        private double KvadratineSaknis(double d1, double d2)
        {
            return Math.Sqrt(d1 + d2);
        }
    }
}