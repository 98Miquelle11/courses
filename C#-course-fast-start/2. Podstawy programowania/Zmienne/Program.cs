using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmienne
{
    internal class Program // każda zmnienna musi mieć przypisany do siebie konkretny typ
    {
        static void Main(string[] args)
        {
            string zmiennapierwsza1 = "Hello, ";
            //string zmiennapierwsza = "World"; nie można dwa razy nadawać wartość tej samej zmiennej
            //string zmiennaPierwsza;
            //string zmienna_pierwsza;
            //string zmienna_pierwsza1;
            //string zmienna pierwsza; - błąd
            //string 4zmiennaPierwsza1; - cyfra nie może być na początku zmiennej
            string zmiennapierwsza2 = "World";
            string zmiennapierwsza3 = "!!!";

            Console.WriteLine(zmiennapierwsza1 + zmiennapierwsza2 + zmiennapierwsza3);
            Console.ReadKey();
        }
    }
}
