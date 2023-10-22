using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Į ekraną išveskite kelis sunumeruotus pasirinkimus
            //1 - stacionarus kompiuteris
            //2 - nešiojamas kompiuteris
            //3 - planšetė
            //Liepkite vartotojui įvesti pasirinkimo numerį.
            //Pagal įvestą numerį išveskite atitinkamą tekstą. Pvz:
            //nešiojamuoju kompiuteriu galite naudotis visur
            //stacionariu kompiuteriu galite naudotis tik namuose arba darbo vietoje
            //planšete galite naudotis visur
            //Neradus tinkamo varianto išvesti, kad tokio pasirinkimo nėra.

            Console.WriteLine("1 - stacionarus kompiuteris");
            Console.WriteLine("2 - nešiojamas kompiuteris");
            Console.WriteLine("3 - planšetė");
            Console.WriteLine();

            Console.Write("Pasirinkite vieną iš aukščiau nurdytų variantų įrašydami varianto numerį: ");
            var variantas = Convert.ToInt32(Console.ReadLine());

            switch (variantas)
            {
                case 1:
                    Console.WriteLine("Stacionariu kompiuteriu galite naudotis tik namuose arba darbo vietoje");
                    break;
                case 2:
                    Console.WriteLine("Nešiojamuoju kompiuteriu galite naudotis visur");
                    break;
                case 3:
                    Console.WriteLine("Planšete galite naudotis visur");
                    break;
                    default: Console.WriteLine("Nurodyto pasirinkimo nėra.");
                    break;
            }
            Console.WriteLine();
        }
    }
}
