using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice_jednowymiarowe
{
    internal class Program
    {
        static void Main(string[] args) // array - ang. tablica
        {
            int[] array = new int[4]; // dopiero [] mówi nam o tym, że to typ tablicowy, a int mówi nam, że ta dane tablicowe będą typu int
            // to po lewej to deklaracja typu danych. Po prawej to definicja. 5 to 5 jednostek przechowywanych informacji.
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            //array[4] = 5; // ostatni indeks

            //Console.WriteLine(array[3]);

            for (int i = 0; i < array.Length; i++) // i <4
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine();

            char[] array2 = {'H', 'e', 'l', 'l', 'o'};

            foreach (char item in array2) // o ile pętla for jest elastyczna odnoścnie tego, które wartości z tablicy chcemy zobaczyć
            {                             // to pętla foreach po prostu przechodzi tablicę od początku do końca.
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
