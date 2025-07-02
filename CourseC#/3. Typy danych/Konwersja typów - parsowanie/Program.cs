using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konwersja_typów___parsowanie // konwersja z jednego typu danych do drugiego
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę: ");
            string tekst = Console.ReadLine();
            //int varInt = int.Parse(tekst);
            //float varFloat = float.Parse(tekst.Replace('A' , '3')); // można tak zamieniać tekst
            float varFloat;
            bool success = float.TryParse(tekst, out varFloat);
            //Console.WriteLine($"{varFloat} - {success}"); // pokaże, że nie udało się przekonwertować

            tekst = varFloat.ToString();
            tekst = true.ToString();
            Console.WriteLine(tekst);

            Console.ReadKey();
        }
    }
}
