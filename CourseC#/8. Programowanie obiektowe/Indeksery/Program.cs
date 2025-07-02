using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indeksery
{
    internal class Program
    {
        class Tekst
        {
            char[] tekst;
            // Właściwość to skrzyżowanie pola i metody – wygląda jak pole, a zachowuje się jak metoda.Dostęp do właściwości
            // odbywa się przy użyciu dokładnie takiej samej składni, jak w przypadku dostępu do pola.  Natomiast kompilator
            // automatycznie zmienia tę składnię na wywołanie metod akcesorów odczytu i zapisu.
            public char this[int n]
            {
                get { return tekst[n]; }
                set { tekst[n] = value; } // dzięki temu powinniśmy uzyskać nową możliwość naszego indeksatora, czyli możliwość przypisywania wartości
            }
            // Blok "get" zawiera instrukcje wykonywane w przypadku odczytu właściwości
            // Blok "set" zawiera instrukcje wykonywane w przypadku zapisu właściwości.
            // Typ właściwości określa typ danych odczytywanych i zapisywanych za pomocą akcesorów get i set.
            public Tekst(string txt) // tworzymy indekser
            {
                tekst = new char[txt.Length];
                for (int i = 0; i < txt.Length; i++)
                {
                    tekst[i] = txt[i];
                }
            }
            public char this [string n] // indeksatory można przeciążać. Ten indekser może być również typu char
            {
                get
                {
                    if (n.Equals("jeden"))
                    {
                        return tekst[0];
                    }
                    return tekst[tekst.Length - 1];
                }
            }
        }
        static void Main(string[] args)
        {
            string text = "Witaj świecie!";
            Console.WriteLine(text[1]); // wyświetli się druga litera bo string zachowuje się tak, jakby był tablicą
            // Nie jest tablicą 1 : 1, ale typ string implementuje indeksery
            Tekst tekst = new Tekst("Hello");
            Console.WriteLine(tekst["jeden"]); // nie zauważymy żadnych zmian w tekście
            tekst[1] = '3';
            for (int i = 0; i <= 4; i++)
            {
                Console.Write(tekst[i]);
            }

            Console.ReadKey();
        }
    }
}
