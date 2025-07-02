using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwracanie_wartości
{
    internal class Program
    {
        static int Add(int a, int b)
        {
            //int sum = a + b;
            //return sum; // to słówko stosuje się na samym końcu, ponieważ zamyka i przerywa działanie funkcji
            // to słówko należy do rodziny słówek skoku, czyli goto, break, continue. Mają to do siebie, że przerywają
            // naturalną kolej rzeczy wykonywania kodu i przeskakują w inne miejsce. Return automatycznie przerywa wykonywanie
            // funkcji i skacze do miejsca jego wywołania czyli Add. Tutaj pobiera ją z sumy i zwraca do int res.

            // return a + b // też może być
            Console.WriteLine("Jestem tutaj");
            return -999; // zostanie zwrócona pierwsza wartość z użyciem return
            int sum = a + b;
            return sum;
            Console.WriteLine("Jestem tutaj"); // po wykorzystaniu return żadna kolejna instrukcja nie zostanie wyświetlona
        }
        static void Main(string[] args)
        {
            int res = Add(5, 10);
            Console.WriteLine(res);
            

            Console.ReadKey();
        }
    }
}
