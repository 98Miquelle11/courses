using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcje_bezargumentowe
{
    internal class Program
    {
        static void Main(string[] args) // dzięki takim zastosowaniom w jednej metodzie zrobimy funkcje, a potem
            // możemy ją wywoływać wszędzie ile tylko chcemy.
        {
            Hello();
            Hello();
            Hello();

            Console.ReadKey();
        }

        static void Hello()
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
