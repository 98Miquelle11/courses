using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> hs = new HashSet<string>();
            hs.Add("Poniedziałek");
            hs.Add("Czwartek");
            hs.Add("Wtorek");
            hs.Add("Środa");
            hs.Add("Czwartek");
            hs.Add("Piątek");
            hs.Add("Piątek");
            hs.Add("Piątek");

            //Console.WriteLine(hs[0]); // nie można zastosować przy użyciu konstrukcji z nawiasami kwadratowymi
            Console.WriteLine(hs.Contains("Poniedziałek"));
            Console.WriteLine("HashSet - ilość: "+ hs.Count); // dalej będziemy mieć tylko 5 elementów. Ponieważ cechą HashSet jest to,
            // że nie liczy powtarzalnych elementów
            foreach (var item in hs)
            {
                Console.WriteLine(item);
            } // tu też to widać

            Console.ReadKey();
        }
    }
}
