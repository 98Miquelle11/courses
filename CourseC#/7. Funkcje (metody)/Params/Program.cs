using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params // params - parametry. Czyli jest w stanie przyjmować nieskończoną ilość argumentów
{
    internal class Program
    {
        static void Print(string text, params string [] arg) // params musi być jednocześnie zadeklarowany jako typ danych tablicowych
        {
            for (int i = 0; i < arg.Length; i++)
            {
                text = text.Replace("{" + i + "}", arg[i]);
            }
            Console.WriteLine(text);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("{0} {1} {2}", "Hello", "World", "!!!", "!!!", "!!!");
            Print("{0} {1} {2}", "Hello", "World", "!!!");
            // params jest w stanie przyjmować nieskończoną ilość argumentów.
            Console.ReadKey();
        }
    }
}
