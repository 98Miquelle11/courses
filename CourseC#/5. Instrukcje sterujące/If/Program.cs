using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ile masz lat?");
            int wiek = int.Parse(Console.ReadLine());
            if (wiek >= 18)
            {
                Console.WriteLine("Zapraszamy!");
                if (wiek >= 50) Console.WriteLine("Stary jesteś...");
            }
            if (wiek < 18) Console.WriteLine("Do widzenia.");
            Console.ReadKey();
        }
    }
}
