using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Raskite visų skaičių nuo 1 iki 100 sumą.

            var suma = 0;

            for (var i = 0; i <= 100; i++)
            {
                suma += i;
            }

            Console.WriteLine(suma);
            Console.WriteLine();

            //Raskite visų lyginių skaičių nuo 20 iki 40 sumą.

            var lyginiuSuma = 0;

            for (var i = 20; i <= 40; i++)
            {
                if (i % 2 == 0)
                {
                    lyginiuSuma += i;
                }
            }

            Console.WriteLine(lyginiuSuma);
            Console.WriteLine();

            //Raskite visų nelyginių skaičių nuo 30 iki 60 sumą.

            var nelyginiuSuma = 0;

            for (var i = 30; i <= 60; i++)
            {
                if (i % 2 != 0)
                {
                    nelyginiuSuma += i;
                }
            }

            Console.WriteLine(nelyginiuSuma);
            Console.WriteLine();

            //Rasti visų skaičių, žemesnių už 1000 ir didesnių už 0 bei kurie dalinasi iš 3 arba
            //5, sumą.
            //Pavyzdys:
            //Visi skaičiai mažesni už 10 ir kurie dalinasi iš 3 arba 5 yra: 3, 5, 6, 9.
            //Šių skaičių suma yra 23.
            //Turite gauti 233168 atsakymą.

            var suma2 = 0;

            for (var i = 0; i < 1000; i++)
            {
                if (i % 3 == 0)
                {
                    suma2 += i;
                }
                else if (i % 5 == 0)
                {
                    suma2 += i;
                }
            }

            Console.WriteLine(suma2);
            Console.WriteLine();

        }
    }
}
