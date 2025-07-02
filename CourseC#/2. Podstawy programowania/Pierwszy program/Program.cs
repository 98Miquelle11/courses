using System; // dzięki temu nie musimy wpisywać tego na pocz. każdej instrukcji
using System.Collections.Generic;
using System.Linq;  // średnk kończy każdą instrukcję kodu.
using System.Text;
using System.Threading.Tasks;

namespace Pierwszy_program // przestrzeń nazw
{
    internal class Program
    {
        static void Main(string[] args) // "Main" to funkcja. "args" to nazwa argumentu, a "string" to typ danych
        {
            Console.Write("Podaj imię: ");
            string name = Console.ReadLine(); // ta funkcja wczytuje jedną linię kodu z ekranu, a name ją przypisuje.
            Console.WriteLine("Hello, {0}!", name);// Console jest klasą. Kropka jest operacją wydostawania
            Console.WriteLine($"Hello, {name}!");// elementów. {0} to pierwszy indeks. W IT liczenie zaczyna się od zera.

            Console.ReadKey();
        }

        // zmienna jest kontenerem, który jes w stanie przechowywać jakąś jednostkę informacji.
    }
}
