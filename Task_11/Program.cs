using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Liepkite vartotojui įvesti tris skaičius, parašyti šią
            //patikrinimo sąlygą, naudojant else if dalis:
            //ar pirmas skaičius didesnis už antrą;
            //ar antras skaičius didesnis už trečią;
            //ar trečias skaičius didesnis už pirmą;
            //ar pirmi du skaičiai lygūs;

            Console.WriteLine("1.");
            Console.WriteLine("Įveskite bet kokius tris skaičius: ");
            var skaicius1 = Convert.ToDouble(Console.ReadLine());
            var skaicius2 = Convert.ToDouble(Console.ReadLine());
            var skaicius3 = Convert.ToDouble(Console.ReadLine());


            if (skaicius1 > skaicius2)
            {
                Console.WriteLine("Pirmasis skaičius didesnis už antrąjį.");
            }
            else if (skaicius2 > skaicius3)
            {
                Console.WriteLine("Antrasis skaičius didesnis už trečiąjį.");
            }
            else if (skaicius3 > skaicius1)
            {
                Console.WriteLine("Trečiasis skaičius didesnis už pirmąjį.");
            }
            else if (skaicius1 == skaicius2)
            {
                Console.WriteLine("Pirmasis ir antrasis skaičiai lygūs");
            }
            Console.WriteLine();

            //Liepkite vartotojui įvesti šios dienos oro temperatūrą, atlikite šiuos patikrinimus:
            //ar temperatūra< 0 - išvesti “žiauriai šalta”;
            //ar temperatūra< 10 - išvesti “labai šalta”;
            //ar temperatūra< 20 - išvesti “šalta”;
            //ar temperatūra< 30 - išvesti “normali temperatūra”;
            //ar temperatūra< 40 - išvesti “karšta”;
            //ar temperatūra >= 40 - išvesti “visiškai degina”;

            Console.WriteLine("2.");
            Console.Write("Įveskite šios dienos oro temperatūrą: ");
            var temperatura = Convert.ToDouble(Console.ReadLine());

            if (temperatura < 0)
            {
                Console.WriteLine("Žiauriai šalta :(");
            }
            else if (temperatura < 10)
            {
                Console.WriteLine("Labai šalta");
            }
            else if (temperatura < 20)
            {
                Console.WriteLine("Šalta.");
            }
            else if (temperatura < 30)
            {
                Console.WriteLine("Normali temperatūra");
            }
            else if (temperatura < 40)
            {
                Console.WriteLine("Karšta");
            }
            else if (temperatura >= 40)
            {
                Console.WriteLine("Visiškai degina");
            }
        }
    }
}
