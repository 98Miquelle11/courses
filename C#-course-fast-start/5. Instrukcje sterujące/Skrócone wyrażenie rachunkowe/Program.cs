using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skrócone_wyrażenie_rachunkowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę: ");
            int a = int.Parse(Console.ReadLine());

            // if {} else {}
            string wynik = a % 2 == 0 ? "Parzysta" : "Nieparzysta";
            // ? to zapytanie (1szy argument skróconego wyrażenia. Jeżeli będzie true to zwróci to co napotka
            // po znaku zapytania. Za dwukrotkiem jest wartość, która ma być zwracana, jeśli warunek jest 
            // nieprawdziwy.
            Console.WriteLine(wynik);
            Console.ReadKey();
        }
    }
}
