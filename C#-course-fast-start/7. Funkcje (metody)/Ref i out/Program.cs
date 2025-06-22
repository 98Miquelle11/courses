using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref
{
    internal class Program
    { 
        static void Test(ref int a, int[] array) // możemy za pomocą ref wysłać wartość poprzez jej referencję
        {
            a = 9;
            //array = new int[1]; // wyświetli się wartość 1, ponieważ to będzie odwołanie do zupełnie nowej tablicy.
            array[0] = 9;
        }
        static void Main(string[] args)
        {
            int a = 1;
            int[] array = new int[1];
            array[0] = 1;
            Test(ref a, array); // tutaj też musimy wstawić przedrostek
            Console.WriteLine($"a = {a}\narray = {array[0]}"); // dla wartości a została taka jak ta zadeklarowana w głównej metodzie.
            // natomiast argument array jak w metodzie Test. Dzieje się tak z powodu złożoności typu array - jest typem referencyjnym.
            // natomiast zmienna a jest typu wartościowego.
            //Tutaj odbywa się wysyłanie argumentów. Różnica jest w sposobach wysyłania. W momencie wysłania tego argumentu do funkcji array
            // mamy do czynienia z typem referencyjnym, tzn., że do funkcji jest przekazywana same referencja tego obiektu, a referencja
            // oznacza tyle, co jest to pewne wskazanie na strukturę, jaką jest cała tablica. Natomiast sama w sobie zmienna array jest tylko
            // wskaźnikiem na początku tablicy. Ona przechowuje pewne informacje, że opisuje pewną tablicę, ale posiada tylko pewne wybiórcze
            // informacje o tej tablicy.

            Console.ReadKey();
        }
        // ref pozwala nie wysyłać kopii wartości, tylko referencję tej wartości. Referencja to wskaźnik na oryginalną wartość.
    }
}
