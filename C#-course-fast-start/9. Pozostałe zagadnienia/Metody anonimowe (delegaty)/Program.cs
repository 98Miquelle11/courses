using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody_anonimowe__delegaty_
{
    internal class Program
    {
        public delegate int CalcDelegate(int a, int b); // typy parametrów są identyczne do tych, których wymaga Func
        static void CalcWithText(Func<int, int, int> func, int a, int b)
        {
            int res = func.Invoke(2, 5);
            Console.WriteLine($"Wynik = {res}");
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            //CalcWithText(CalcDelegate(2, 5), 2, 5);
            CalcDelegate calcDelegate = Add; // delegat ma teraz informację o pewnej metodzie, która została do niego przypisana
            CalcWithText(calcDelegate.Invoke, 2, 5);

            CalcDelegate calcDelegate2 = delegate (int a, int b) // typy danych muszą być dokładnie tak samo zadeklarowane jak u delegata
            {
                return a + b;
            };
            Console.WriteLine(calcDelegate2.Invoke(2,5)); // nie skorzystaliśmy tutaj z delegatu metody CalcWithText
            // metody anonimowe są często jednorazowe, ponieważ łatwo stracić do nich dostęp
            Func<int, int, int> funcDelegate = Add;
            CalcWithText(funcDelegate.Invoke, 2, 5);
            Action<int, int> action = delegate (int a, int b) // action niczego nie zwraca
            {
                Console.WriteLine(a + b);
            };
            action.Invoke(2, 5);
            Predicate<int> predicate = delegate (int a)// predicate przyjmuje tylko jeden parametr; predicate - wskazywać
            {
                return a == 0; // sprawdzamy, czy wartość a jest równa 0
            };
            Console.WriteLine(predicate.Invoke(5));
            Console.WriteLine(predicate.Invoke(0));

            Console.ReadKey();
        }
    }
}
