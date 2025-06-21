using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typ_znakowy___tekstowy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char varChar = 'A'; // char od character - pol. znak. Dla znaku przewidziane są apostrofy, nie cudzysłowia.
            Console.WriteLine(varChar.ToString());
            Console.WriteLine((int)varChar);

            string varString = "\nJakiś tekst!".ToUpper(); // pojedyńczy charakter, który da nam linię odstępu.
            Console.WriteLine(varString + "\"\\ - "); // backslashe zamykają

            // string nie jest typem danych prymitywnym. Jest zbudowany na bazie klasy.

            // na koniec każdej instrukcji w nawiasie można dać kropkę i zobaczyć, co dana funkcja może zrobić.

            Console.ReadKey();
        }
    }
}
