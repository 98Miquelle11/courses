using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj tekst: ");  // char jest typem znakowym. Pozwala przechowywać pojedyncze znaki
            string text = Console.ReadLine();//  (małe i wielkie litery, cyfry, znaki przestankowe itp.).
                                             //  Wartości typu char są w języku C++ otoczone apostrofami,
            foreach (char c in cokolwiek)   //  np. 'a', '8', '+', '.'
            {                                // in jest rozdzieleniem lewej sekcji od prawej w pętli foreach
                Console.WriteLine(c);
            }

            Console.ReadKey();
        } // pętla foreach rozbiera kolekcję na części pierwsze i wyciąga ją po elemencie od pierwszego do
          // końca.
    }
}
