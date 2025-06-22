using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argumenty_nazwane
{
    internal class Program
    {
        static void Hello(string text,int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(text);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Hello("Hello World!", 3);
            // Hello(3, "Hi"); kolejność argumentów musi być taka sama jak w momencie deklaracji tych argumentów
            Hello(times: 3, text: "Jadwiga"); // teraz można dzięki argumentom nazwanym

            Console.ReadKey();
        }
    }
}
