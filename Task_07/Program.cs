using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Liepkite vartotojui įvesti savo vardą ir amžių.
            //Į ekraną išveskite: “Jūsų vardas { vardas}, o amžius { amžius}.”

            Console.WriteLine("1.");
            Console.Write("Įveskite savo vardą: ");
            string vardas = Console.ReadLine();
            Console.Write("Įveskite savo amžių: ");
            int amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Jūsų vardas {vardas}, o amžius {amzius}");
            Console.WriteLine();

            //Liepkite vartotojui įvesti bet kokį simbolį.
            //Atspausdinkite 3x3 kvadratą iš to simbolio.

            Console.WriteLine("2.");
            Console.Write("Įveskite bet kokį simbolį: ");
            var simbolis = Console.ReadLine();
            Console.WriteLine("{0}{0}{0}", simbolis);
            Console.WriteLine("{0}{0}{0}", simbolis);
            Console.WriteLine("{0}{0}{0}", simbolis);
            Console.WriteLine();

            //Liepkite vartotojui įvesti bet kokį skaičių.
            //Išveskite į ekraną šio skaičiaus kvadratą.

            Console.WriteLine("3.");
            Console.Write("Įveskite bet kokį skaičių: ");
            double skaicius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"šio skaičiaus kvadratas yra {skaicius * skaicius}");
            Console.WriteLine();

            //Liepkite vartotojui įvesti tris skaičius.
            //Išveskite visų šių skaičių sumą, nurodant atliekamus veiksmus
            //ir šių skaičių reikšmes ekrane. Pvz.:
            //5 + 3 + 8 = 16

            Console.WriteLine("4.");
            Console.WriteLine("Įveskite bet kokius tris skaičius: ");
            double skaicius1 = Convert.ToDouble(Console.ReadLine());
            double skaicius2 = Convert.ToDouble(Console.ReadLine());
            double skaicius3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"{skaicius1} + {skaicius2} + {skaicius3} = {skaicius1 + skaicius2 + skaicius3}");
            Console.WriteLine();
        }
    }
}
