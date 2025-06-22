using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Else_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę:");
            int num = int.Parse(Console.ReadLine());

            /*
            if (num > 0) Console.WriteLine("Liczba jest większa od 0");
            else
            {
                if (num < 0) Console.WriteLine("Liczba jest mniejsza od 0");
                else Console.WriteLine("Liczba jest równa 0");
            }
            */
            if (num > 0) Console.WriteLine("Liczba jest większa od 0");
            else if (num < 0) Console.WriteLine("Liczba jest mniejsza od 0");
            else if (num == 0) Console.WriteLine("Liczba jest równa 0");
            Console.ReadKey();  
        }
    }
}
