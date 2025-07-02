using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoda_jako_argument_innej_metody
{
    internal class Program
    {                           // .fun to jedna z odmian delegatów. Delegat jest nagłówkiem bez żadnego ciała
        static void CalcWithText(Func<int, int, int> func, int a, int b) // przyjmuje pewną ilość argumentów. Zwraca rezutat w tym samym typie
        {                                             // wartość po prawej stronie to wartość zwracana, a pozostałe to parametry naszej funkcji
            //int res  = func(a, b); // wywołuję funkcję, która zostanie do mnie dostarczona w momencie użycia
            //int res = func.Invoke(2, 5); //w tym miejscu dostarczam parametry, które normalnie dostarczyłbym do wywołania funkcji. Najczęściej wykorzystywane.
            int res = func(2, 5);
            // 
            Console.WriteLine($"Wynik = {res}");
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            CalcWithText(Add, 2, 5);


            Console.ReadKey();
        }
        // za sumowanie obliczenia odpowiada nam metoda Add. Natomiast wnętrze pochodzi z metody CalcWithText
    }
}
