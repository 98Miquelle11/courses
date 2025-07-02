using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wartości_domyślne
{
    internal class Program
    {
        static void Hello(string text = "Hello!", int times = 2) // zdefiniowaliśmy argument, dzięki czemu stał się domyślny
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(text);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Hello("Hello World!", 3); // jeśli nadamy swój argument, to zostanie przyjęty zamiast domyślnego
            Hello("Jadwiga"); // dzięki temu nie ma błędu, pomimo nie nadania drugiego argumentu, ponieważ przyjmuje wartość domyślną
            Hello();

            Console.ReadKey();
        }
    }
}
