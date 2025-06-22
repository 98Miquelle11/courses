using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If__else
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ile masz lat?");
            int wiek = int.Parse(Console.ReadLine());
            /*
            if (wiek >= 18)
            {
                Console.WriteLine("Zapraszamy!");
            }
            else
            {
                Console.WriteLine("Do widzenia.");
            }
            */
            if (wiek >= 18) Console.WriteLine("Zapraszamy!");
            else
            {
                Console.WriteLine("Do widzenia."); // do min 2 linijek kodu do rozdzielenia potrzebne
                Console.WriteLine("Przykro nam...");  // są klamry
            }
            Console.ReadKey();
        }
    }
}
