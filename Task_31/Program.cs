using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Parašykite sumos funkciją su 3 parametrais, kuris gražina int tipo atsakymą.
            Console.WriteLine("Užduotis 1. ");
            Program p1 = new Program();
            var result1 = p1.Suma1(7,12,80);
            Console.WriteLine(result1);
            Console.WriteLine();

            //Parašykite dalmens funkciją su 2 parametrais, kuris gražina double tipo  atsakymą.
            Console.WriteLine("Užduotis 2. ");
            Program p2 = new Program();
            var result2 = p2.Suma2(80,10);
            Console.WriteLine(result2);
            Console.WriteLine();

        }
        private int Suma1(int a, int b, int c)
        {
            return a + b + c; 
        }

        private double Suma2(double a, double b)
        {
            return a / b;
        }
    }
}
