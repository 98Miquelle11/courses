using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stałe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STAŁE

            const string LANGUAGE = "C#"; // wgl konwencji stałe oznacza się wielkimi literami
                                          // nie jesteśmy w stanie zmienić teraz tej wartości.
            Console.WriteLine(LANGUAGE);
            Console.WriteLine(Math.PI);
            Console.ReadKey();
        }
    }
}
