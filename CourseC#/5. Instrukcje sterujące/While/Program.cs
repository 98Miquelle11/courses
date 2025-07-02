using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę: ");
            int a = int.Parse(Console.ReadLine());
            int i = 1;

            while (i <= a)
            {
                Console.WriteLine(i);
                i++;
                // break; zakończyłoby nam pętle po pierwszym wyrażeniu
            }

            Console.ReadKey();
        }
    }
}
