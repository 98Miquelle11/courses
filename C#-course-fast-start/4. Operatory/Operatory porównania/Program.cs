using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatory_porównania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Podaj B: ");
            int b = int.Parse(Console.ReadLine());

            bool wynik = a == b; // 2 razy =, ponieważ chcemy porównać, a nie przypisać wartość.
            Console.WriteLine(wynik);
            //ewentualnie
            Console.WriteLine($"{a} == {b} = {a == b}"); 
            Console.WriteLine($"{a} != {b} = {a != b}"); // negacja
            Console.WriteLine($"{a} > {b} = {a > b}");
            Console.WriteLine($"{a} < {b} = {a < b}");
            Console.WriteLine($"{a} <= {b} = {a <= b}");
            Console.WriteLine($"{a} >= {b} = {a >= b}");

            Console.ReadKey();
        }
    }
}
