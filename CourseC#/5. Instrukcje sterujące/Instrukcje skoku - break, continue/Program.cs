using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instrukcje_skoku___break__continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; ; i++)
            {
                if (i > 20)
                {
                    break; // pętla automatycznie się zakończy przy 20
                }
                if (i % 2 == 1)
                {
                    continue; // pomija wartości z pętli - przechodzi do kolejnego obiektu pętli.
                }
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
