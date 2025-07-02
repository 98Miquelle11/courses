using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyrażenie_lambda
{
    internal class Program
    {
        public delegate int CalcDelegate(int a, int b);
        static void CalcWithText(Func<int, int, int> func, int a, int b)
        {
            int res = func.Invoke(2, 5);
            Console.WriteLine($"Wynik = {res}");
        }
        static void Main(string[] args)
        {

            CalcDelegate calcDelegate2 = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine(calcDelegate2.Invoke(2, 5));

            CalcWithText(delegate (int a, int b)
            {
                return a + b;
            },2,5);
            // to całe poniżej odpowiada wcześniejszej metodzie Add (w przypadku klas anonimowych i metod w metodach)
            CalcWithText((x, y) => x + y, 2,5); // stworzenie na potrzeby parametru nowej metody anonimowej, identycznej jak wcześniej powstały. Jeżeli funkcja
            // przyjmuje tylko jeden parametr, to nawiasy w nawiasach są niewymagane



            Console.ReadKey();
        }
    }
}
