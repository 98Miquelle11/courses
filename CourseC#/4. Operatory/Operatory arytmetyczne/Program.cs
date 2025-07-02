using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatory_arytmetyczne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Podaj B: ");
            int b = int.Parse(Console.ReadLine());
            int wynik = a + b;

            Console.WriteLine($"{a} + {b} = {a+b}"); // dolar pozwala od razu wstawienie zmiennych zamiast {0},{1}, itd.
            Console.WriteLine(a - b); // tutaj pokaże już wynik
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} / {b} = {(float)a / (float)b}");
            Console.WriteLine($"{a} % {b} = {a % b}"); // wydaje reszte z dzielenia
            Console.WriteLine("============================");
            Console.WriteLine(Math.Pow(a,b));
            Console.WriteLine(Math.Sqrt(a));

            Console.ReadKey();
        }
    }
}
