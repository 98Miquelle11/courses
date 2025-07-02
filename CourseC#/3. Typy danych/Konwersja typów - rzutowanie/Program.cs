using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konwersja_typów___rzutowanie
{
    internal class Program // rzutowanie jawne i niejawne
    {
        static void Main(string[] args)
        {
            int varInt = 200000;
            long varLong;

            varLong = varInt; // zaszło niejawne rzutowanie. Intiger zmieści się w longu
            Console.WriteLine(varLong);

            short varShort;
            //varShort = varInt; // nie można niejawnie przekonwertować int na short.
            varShort = (short)varInt;
            Console.WriteLine(varShort); // zapisało się tylko tyle bitów ile short posiada

            float varFloat = 5.5f;
            varLong = (long)varFloat;
            Console.WriteLine(varLong); // pokaże tylko wartość całkowitą

            varFloat = varInt;
            Console.WriteLine(varFloat); // tutaj nie ma problemu bo float również zawiera liczby całkowite

            string tekst = "123";
            varInt = (int)(object)tekst;
            Console.WriteLine(tekst);

            Console.ReadKey();
        }
    }
}
