using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 2; // var jest dowolnym typem danych, jaki chcemy wprowadzić w C#
            Console.WriteLine(a);
            Console.WriteLine(a.GetType());

            var tekst = "Hello"; // var jest dowolnym typem danych, jaki chcemy wprowadzić w C#
            Console.WriteLine(tekst);
            Console.WriteLine(tekst.GetType());

            //tekst = 123 // jak var przybrał postać "string" to nie może się już zmienić na "int"
            var c = "?";

            Console.ReadKey();
        }
    }
}
