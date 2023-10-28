using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Įvesti du skaičius iš konsolės
            //Paklausti vartotojo kokį veiksmą su tais skaičiais nori atlikti: Daugybą ar  dalybą
            //Parašyti po atskirą metodą kiekvienam veiksmui(daugybai naudoti int tipą, o  dalybai double)
            //Su if patikrinti kokį veiksmą atlikti ir išsikviesti atitinkamą metodą, jei tokio  veiksmo nėra – informuoti vartotoją, jog tokio veiksmo nėra.

            Console.WriteLine("Įveskite du skaičius: ");
            int ivestasSkaicius1 = Convert.ToInt32(Console.ReadLine());
            int ivestasSkaicius2 = Convert.ToInt32(Console.ReadLine());
            Program aritmetinisVeiksmas = new Program();

            Console.WriteLine("Pasirinkite, kokį veiksmą norite atlikti su šiais skaičiais: ");
            Console.WriteLine("1 - jei daugyba ");
            Console.WriteLine("2 - jei dalyba ");
            int veiksmas = Convert.ToInt32(Console.ReadLine());

            if (veiksmas == 1)
            {
                var resultDaugyba = aritmetinisVeiksmas.Daugyba(ivestasSkaicius1, ivestasSkaicius2);
                Console.WriteLine($"Atsakymas: {resultDaugyba}");
                Console.WriteLine();
            }
            else if (veiksmas == 2)
            {
                var resultDalyba = aritmetinisVeiksmas.Dalyba(ivestasSkaicius1, ivestasSkaicius2);
                Console.WriteLine($"Atsakymas: {resultDalyba}");
                Console.WriteLine();
            }
            else 
            {
                Console.WriteLine("Tokio veiksmo nėra.");
            }
        }

        private double Daugyba(double a1, double a2)
        {
            return a1 * a2;
        }
        
        private double Dalyba(double b1, double b2)
        {
            return b1 / b2;
        }
    }
}
