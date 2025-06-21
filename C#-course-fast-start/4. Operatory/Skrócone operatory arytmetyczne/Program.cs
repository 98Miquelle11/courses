using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skrócone_operatory_arytmetyczne
{
    internal class Program // dry - dont repeat yourself
    {
        static void Main(string[] args)
        {
            int a = 5;
            a += 10; // przypisuje wartość +10 czyli 15
            a -= 3; // teraz od ostatniej liczby odejmuje 3 czyli 12
            a *= 2; // 12 pomnoży *2 wiec bedzie 24
            a /= 6; // podzieli przez 6 ostatnią wartość, więc będzie 4

            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
