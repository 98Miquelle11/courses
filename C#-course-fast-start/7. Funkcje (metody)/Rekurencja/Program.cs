using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekurencja // zdolność wywoływania funkcji przez samą siebie
{ // rekurencja może czasem okazać się szybsza, ale pobiera większe ilości pamięci
    internal class Program
    {
        static int Silnia(int n) // błąd będzie występował tak długo, dopóki nie użyjemy słowa kluczowego return
        { // !0 = 1
            if (n == 0) return 1;
            else return n * Silnia(n-1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("n = 1: " + Silnia(1));
            Console.WriteLine("n = 2: " + Silnia(2));
            Console.WriteLine("n = 3: " + Silnia(3));
            Console.WriteLine("n = 4: " + Silnia(4));
            Console.WriteLine("n = 5: " + Silnia(5));
            Console.WriteLine("n = 5: " + Silnia(-5)); // stack overflow oznacza, że było tyle wykonań tej funkcji, że program się zawiesił

            Console.ReadKey();
        }
    }
}
