using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sl = new SortedList<int, string>();
            sl.Add(1, "Poniedziałek");
            sl.Add(2, "Wtorek");
            sl.Add(3, "Środa");
            sl.Add(4, "Czwartek");
            sl.Add(5, "Piątek");
            //sl.Add(5, "Piątek"); // kolekcja napotka błąd, ponieważ znalazła klucz powtarzalny

            //Console.WriteLine(sl[0]); // indek w SortedList == klucz. Nie ma takiego klucza
            Console.WriteLine(sl[1]);
            foreach (var item in sl)
            {
                Console.WriteLine(item); // to co przechowuje się w tej kolekcji to klucz i wartość. To ze względu na jego klasę
            }
            Console.WriteLine("\n");
            foreach (KeyValuePair<int,string> item in sl)
            {
                Console.WriteLine(item.Key + " - " + item.Value); // trzeba rozdzielić
            }
            Console.WriteLine("-----------------");
            Console.WriteLine(sl.Keys[0]); // pierwszy klucz, który występuje na naszej liście
            Console.WriteLine(sl.Values[0]); // pierwsza wartość

            foreach(var item in sl.Values)
            {
                Console.WriteLine(item); // można też zrobić z kluczami
            }

            Console.ReadKey();
        }
    }
}
