using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goto
{
    internal class Program
    {
        static void Main(string[] args) // goto też jest instrukcją skoku
        {
        /*
        hello: // to jest etykieta i pod tą etykietą znajduje się wszystko co jest w dół
            string a = Console.ReadLine();
            //Console.WriteLine(a);

            goto hello; // z linii 16 skaczemy do linii 13 i program z tego miejsca działa na nowo
        */

            int i = 0;
        hello:
            Console.WriteLine("Hello World");
            i++;

            if (i < 10)
            {
                goto hello; // go to dzieje się dopóki i bedzie mniejsze od 10 czyli skończy się na 10 wywołaniach
            }

            Console.ReadKey();
        }
    }
}
