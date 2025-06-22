using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Poniedziałek");
            dictionary.Add(2, "Wtorek");
            dictionary.Add(3, "Środa");
            //dictionary.Add(3, "Środa"); nie mogą być dwa takie same indeksy
            dictionary.Add(0, "Środa"); // dictionary sam z siebie się nie sortuje

            Console.WriteLine(dictionary[1]);

            foreach(var item in dictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            SortedDictionary<int, string> sd = new SortedDictionary<int, string>();
            sd.Add(5, "Piątek");
            sd.Add(4, "Czwartek");
            foreach (var item in sd)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            } // będzie posortowane

            Console.ReadKey();
        }
    }
}
