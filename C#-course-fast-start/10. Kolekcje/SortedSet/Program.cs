using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet_i_SortedSet
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
            Console.WriteLine("HashSet - ilość: " + hs.Count); // dalej będziemy mieć tylko 5 elementów. Ponieważ cechą HashSet jest to,
            // że nie liczy powtarzalnych elementów
            foreach (var item in hs)
            {
                Console.WriteLine(item);
            } // tu też to widać

            SortedSet<string> ss = new SortedSet<string>();
            ss.Add("Piątek");
            ss.Add("Sobota");
            ss.Add("Sobota");
            ss.Add("Sobota");
            ss.Add("Sobota");
            ss.Add("Niedziela");
            
            Console.WriteLine("HashSet - ilość: " + ss.Count);
            foreach (var item in ss)
            {
                Console.WriteLine(item);
            } // zostały posortowane alfabetycznie. Tu również nie dochodzi do powtórzeń

            Console.WriteLine("\nOperacje: ");
            //hs.UnionWith(ss);
            //hs.ExceptWith(ss); // pozbyć się wspólne rzeczy
            //hs.IntersectWith(ss); // część wspólna
            //hs.SymmetricExceptWith(ss); pozbywamy się rzeczy, które są częścią wspólną
            foreach (var item in hs)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            Console.WriteLine(hs.IsSubsetOf(ss)); // sprawdza czy hs jest podzbiorem ss
            Console.WriteLine(hs.IsSubsetOf(hs));
            Console.WriteLine(hs.IsSupersetOf(ss)); // sprawdza na odwrót

            Console.ReadKey();
        }
    }
}
