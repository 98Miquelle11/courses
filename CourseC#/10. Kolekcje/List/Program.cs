using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        class Test
        {
            public void SayHi()
            {
                Console.WriteLine("Hello!");
            }
        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(5);
            list.Add(15);
            list.Add(-5);
            list.Add(10);
            list[0] = 1; // dojdzie do modyfikacji

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            List<Test> list2 = new List<Test>(); // kolekcja list ma to ograniczenie, że skupia się tylko na jednym typie danych
            list2.Add(new Test());
            list2.Add(new Test());
            list2.Add(new Test());

            foreach(var item in list2)
            {
                item.SayHi();
            }

            Console.ReadKey();
        }
    }
}
