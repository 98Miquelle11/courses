using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typ_zmiennoprzecinkowy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float varFloat = 3.14f; // musimy dopisac to f
            Console.WriteLine(varFloat);
            Console.WriteLine($"Float min: {float.MinValue}, max: {float.MaxValue}");

            double varDouble = 13.234; // posiada 2 razy większą ilość miejsca od typu float
            Console.WriteLine($"Double min: {double.MinValue}, max: {double.MaxValue}");
            Console.WriteLine("{0:N20}", 0.1f); // zmienne mają pewne spaczenie obliczeń

            decimal varDecimal = 5.5m; // posiada 2 razy większą ilość miejsca od typu float
            Console.WriteLine($"Decimal min: {decimal.MinValue}, max: {decimal.MaxValue}");
            Console.WriteLine("{0:N20}", 5.5m); // typ decimal daje nam większą dokładność

            Console.ReadKey();
        }
    }
}
