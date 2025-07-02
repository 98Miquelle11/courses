using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj dzień tygodnia: ");
            int a = int.Parse(Console.ReadLine());

            switch(a) // switch dzieli się na przypadki
            {
                case 1: Console.WriteLine("Poniedziałek"); break; //break kończy ten przypadek
                case 2: Console.WriteLine("Wtorek"); break;
                case 3: Console.WriteLine("Środa"); break;
                case 4: Console.WriteLine("Czwartek"); break;
                case 5: Console.WriteLine("Piątek"); break;
                case 6:
                case 7: Console.WriteLine("Weekend"); break; // przez brak break'a przy 6stce komenda działa
                default: Console.WriteLine("Tydzień nie ma tylu dni."); break; // odpowiednik else

            }
            Console.ReadKey();
        }
        
    }
}
