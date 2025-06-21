using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkrementacja_i_dekrementacja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            a += 1; // a++;

            a -= 1; // a--;
            Console.WriteLine(a);
            Console.WriteLine(a++); // post inkrementacja. Tutaj zostanie wysłana informacja o funkcji. Dopiero w kolejnym
            Console.WriteLine(a--); // poleceniu zostanie wyświetlona
            Console.WriteLine(a);
            Console.WriteLine(++a); // tu nastąpiła preinkrementacja
            Console.WriteLine(--a); // tu predekrementacja

            Console.ReadKey();
        }
    }
}
