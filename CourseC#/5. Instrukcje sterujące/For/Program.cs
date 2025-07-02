using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę: ");
            int a = int.Parse(Console.ReadLine());
            int i = 1;

            for ( ; i <= 10; i += 1) // 1sza część to start, druga to koniec, 3cia to proces
            {

                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
