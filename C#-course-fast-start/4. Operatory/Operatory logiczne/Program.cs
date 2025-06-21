using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatory_logiczne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = 5 > 2 && 2 == 1; // oraz
            bool b = 5 > 2 || 2 == 1; // albo
            bool wynik = !false;
            bool c = true || false && false; // logiczne "i" ma pierwszeństwo nad operatorem "lub"

            Console.WriteLine(b);
            Console.WriteLine(wynik);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
