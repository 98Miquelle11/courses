using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out // out dopuszcza nieprzypisywanie wartości do zmiennej, którą wysyłamy do funkcji poprzez słowo kluczowe out
{
    internal class Program
    {
        static void Test(out int a, out int[]array)
        { // wszystkie zmienne muszą zostać przypisane, zanim funkcje sterujące zakończą działania metody
            //return; // tu jest błąd
            a = 9;
            array = new int[1];
            return; // tu nie ma błędu
            array[0] = 9;
        }
        static void Main(string[] args)
        {
            int a; // dalej będzie równa 9
            int[] array = new int[1];
            array[0] = 1;
            Test(out a, out array);
            Console.WriteLine($"a = {a}\narray = {array[0]}");

            int c; // zmienna nie musi mieć przypisanej wartości początkowej
            bool check = int.TryParse("abc", out c);
            Console.WriteLine(check);

            Console.ReadKey();
        }
    }
}
