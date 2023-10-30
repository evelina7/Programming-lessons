using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Liepkite vartotojui įvesti teigiamą skaičių.
            //Ciklo pagalba šį skaičių išvesti mažėjimo tvarka iki kol jis pasieks 0.
            //Pvz.: 5 4 3 2 1.Kiekvieną kartą išvesti skirtingose eilutėse.

            Console.Write("Įveskite teigiamą skaičių ");
            var teigiamasSkaicius = Convert.ToDouble(Console.ReadLine());

            while (teigiamasSkaicius > 0)
            {
                Console.Write($"{teigiamasSkaicius} ");
                teigiamasSkaicius--;
            }

            Console.WriteLine();
            Console.WriteLine();

            //Liepkite vartotojui įvesti neigiamą skaičių.
            //Ciklo pagalba šį skaičių išvesti didėjimo tvarka iki kol jis pasieks 0,
            //taip pat išvesti 0.Pvz.: -4 - 3 - 2 - 1 0.
            //Kiekvieną kartą išvesti toje pačioje eilutėje, skaičius atskiriant tarpais.

            Console.Write("Įveskite neigiamą skaičių ");
            var neigiamasSkaicius = Convert.ToDouble(Console.ReadLine());

            while (neigiamasSkaicius <= 0)
            {
                Console.Write($"{neigiamasSkaicius} ");
                neigiamasSkaicius++;
            }

            Console.WriteLine();
            Console.WriteLine();

            //Padarykite skaičiuotuvą. Kiekvieno ciklo iteracijos metu vartotojas turi suvesti du skaičius.
            //Iš šių skaičių turi būti grąžinami visi sudėties, skirtumo, sandaugos ir dalmens atsakymai,
            //išvedant kartu ir atliekamus veiksmus. Pvz.:
            //5 + 4 = 9
            //5 - 4 = 1
            //…
            //Programa vykdoma tol, kol vartotojas nori atlikinėti skaičiavimus.

            var skaiciuotuvas = "t";

            while ( skaiciuotuvas == "t")
            {
                Console.WriteLine("Įveskite bet kokius du skaičius ");
                var skaicius1 = Convert.ToInt32(Console.ReadLine());
                var skaicius2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine($"{skaicius1} + {skaicius2} = {skaicius1 + skaicius2}");
                Console.WriteLine($"{skaicius1} - {skaicius2} = {skaicius1 - skaicius2}");
                Console.WriteLine($"{skaicius1} * {skaicius2} = {skaicius1 * skaicius2}");
                Console.WriteLine($"{skaicius1} / {skaicius2} = {skaicius1 / skaicius2}");
                Console.WriteLine();
                Console.WriteLine("Jei norite  naudotis skaičiuotuvu, spauskite t ");
                skaiciuotuvas = Console.ReadLine();
            }
        }
    }
}
