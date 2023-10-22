using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Susikurti žodžių sąrašą.Rasti trumpiausią ir ilgiausią žodžius, juos išvesti į ekraną, prie kiekvieno pasakant iš kiek raidžių jis yra sudarytas.
            //Tip: string kintamasis iš tiesų yra char masyvas, todėl galite naudoti
            //zodis.Length

            List<string> listZodziai = new List<string>();

            listZodziai.Add("Ruduo");
            listZodziai.Add("Žiema");
            listZodziai.Add("Pavasaris");
            listZodziai.Add("Vasara");

            foreach (string zodis in listZodziai)
            {
                Console.WriteLine(zodis);
            }

            Console.WriteLine("Ilgiausias žodis: " + listZodziai.Min() + " - " + listZodziai.Max(x => x.Length) + " simboliai ");  // kodėl min atvaizduoja ilgiausią žodį??? 
            Console.WriteLine("Trumpiausias žodis: " + listZodziai.Max() + " - "  + listZodziai.Min(x => x.Length) + " simboliai "); // kodėl max atvaizduoja trumpiausią žodį??? 
            Console.WriteLine();

            //du žodžiai yra vienodo ilgio, nesugalvojau, kaip su listu padaryti, kad atvaizduotų abu pvz. 
        }
    }
}
