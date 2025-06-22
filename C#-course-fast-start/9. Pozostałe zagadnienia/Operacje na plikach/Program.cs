using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Operacje_na_plikach
{
    internal class Program
    {
        static void Main(string[] args)
        {        //za pomocą tej klasy zapisujemy dane        //, bool append daje możliwość dołączania danych
            StreamWriter sw = new StreamWriter("../../../file.txt",true); // cofnięcie się o 3 foldery wstecz
            sw.WriteLine(Console.ReadLine()); // wynik jednej metody zostanie przekazany jako argument do drugiej metody i zostanie wyświetlona
            sw.Close(); // zamykamy plik (wątek), nie marnujemy zasobów. Potem będziemy musieli na nowo otworzyć ten plik.

            Console.WriteLine("\nZawartość pliku:");
            StreamReader sr = new StreamReader("../../../file.txt", true);

            string line;
            while((line = sr.ReadLine()) != null) // zwraca tak długo ciąg znaków jak dużo jest linijek
            { // w pętli while można dokonać również przypisania
                Console.WriteLine(line);
            }
            sr.Close();

            Console.ReadKey();
        }
    }
}
