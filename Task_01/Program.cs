using System;
using System.Text;


namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            /*
             Parašykite programą, kuri išvestų žodį “Labas” ir 
             jūsų vardą toje pačioje eilutėje.
             */

            Console.Write("1. ");
            Console.Write("Labas, Evelina");
            Console.WriteLine();

            /*
             Susikurkite kintamąjį žmogaus amžiui nusakyti, išveskite 
            į ekraną tekstą su šiuo amžiumi: “Įvestas amžius: {amžius}”. 
            Tarp {} nurodytas kintamasis, kurio reikšmė toje vietoje 
            turi būti įstatyta.
             */
      
            int a = 20;
            Console.Write("2. ");
            Console.Write("Įvestas amžius: {0}", a);
            Console.WriteLine();

            /*
             Susikurkite skaičiaus kintamąjį, kurį išveskite 
            penkis kartus toje pačioje eilutėje be tarpų tarp 
            šių skaičių (skaičius - 25, išvedimas - 2525252525).
             */

            var number = 25;

            Console.Write("3. ");
            Console.Write("{0}{0}{0}{0}{0}",number);
            Console.WriteLine("");

            /*
             Susikurkite skaičiaus kintamąjį, kurį išveskite penkis 
            kartus toje pačioje eilutėje su tarpais tarp šių skaičių 
            (skaičius - 25, rezultatas - 25 25 25 25 25).
             */

            Console.Write("4. ");
            Console.Write("{0} {1} {2} {3} {4}", number, number, number, number, number);
            Console.WriteLine("");

        }
    }
}
