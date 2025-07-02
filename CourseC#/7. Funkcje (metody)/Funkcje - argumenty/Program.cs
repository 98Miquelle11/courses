using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcje___argumenty
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Hello(); // funkcja nie akceptuje takiego wywołania
            Hello("Hello, World!", 7);
            Console.ReadKey();
        }

        static void Hello(string text, int times)
        {
            for (int i = 1; i <= times; i++) // albo (int i = 0; i < times; i++) bo w infie liczy sie od zera
            {
                Console.WriteLine(text);
            }
        }
    }
}
