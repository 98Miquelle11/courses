using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przeciążanie_nazw_funkcji // przydaje się wtedy, kiedy chcemy zachować jedną nazwę funkcji, ale dać jej szereg różnych zastosowań
{
    internal class Program
    {
        static void Add(int a)
        {
            Console.WriteLine(++a); // nie post tylko preinkrementacja, ponieważ postinkrementacji nie zauważymy
        }
        static double Add(double a)
        {
            return (int)++a;
        }
        //static int Add(int a) // nie zadziała użycie takiej samej metody, zmieniając tylko typ
        //{
        //    return a;
        //}
        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void Add(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }
        static void Main(string[] args)
        {
            Add(5);
            Add(4,5); // program się domyślił, że chodzi o drugą wersję metody
            Add(1, 2, 3);
            Add(3.55); // nie wyświetli się żadna wartość

            Console.ReadKey();
        }
    }
}
