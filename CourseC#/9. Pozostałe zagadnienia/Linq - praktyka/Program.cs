using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq; // dodajemy tutaj.

namespace Linq___praktyka // Linq to pewien rodzaj biblioteki. Coś w stylu języka SQl dla baz danych. SQl to pewien język zapytań, który pozwala
                          // na komunikownie się z bazą danych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, -10, 7, 0, 1, 2, 1, 9, -5 };
            foreach(int item in arr)
            {
                if (item >= 0)
                {
                    Console.Write("{0,4}", item);
                } // wygodniej użyć Linq. Musimy go dodać w przestrzeni nazw
            }
            // Linq jest dodawany automatycznie do obiektów, które spełniają cechy kolekcji. Taką kolekcją niewątpliwie jest tablica.

            arr.Where(x => x > 0); // Where jest w stanie odfiltrować przez pewne kryteria pod pewnymi warunkami.
            // Metoda Where zwraca nam wynik nowych rozwiązań, ale nie modyfikuje oryginału naszej tablicy

            arr = arr.Where(x => x > 0).ToArray(); // domyślnie jest tutaj zwracana kolekcja innego typu niż tablicowy, dlatego trzeba to skonwertować
            Console.WriteLine("\n");
            foreach (int item in arr)
            {
                Console.Write("{0,4}", item);
            }
            // można w jeszcze inny sposób
            Console.WriteLine("\n");
            arr = arr.Where(x => x > 0).Select(x => x*2).ToArray();
            foreach (int item in arr)
            {
                Console.Write("{0,4}", item);
            }
            Console.WriteLine("\n");
            Console.WriteLine($"First = {arr.FirstOrDefault()}");
            Console.WriteLine($"Sum = {arr.Sum()}");
            Console.WriteLine($"Avg = {Math.Round(arr.Average(),2)}");

            Console.ReadKey();
        }
    }
}
