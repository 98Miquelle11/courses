using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Średnia_arytmetyczna___praktyka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a;
            float sum = 0;
            int i = -1; // o jedno mniej ponieważ wtedy będzie dzielone przez jedną wartość mniej.

            //for (i = 0; i < args.Length; i++) // pętla z licznikiem nie jest tu najlepszą opcją

            do
            {
                Console.Write("Podaj liczbę: ");
                a = float.Parse(Console.ReadLine());
                if (a == 0) // dla podwójnego zabezpieczenia
                {
                    break;
                }
                sum = sum + a; // sum += a; 
                i++;
            } while (a != 0); // przerywamy dodawanie kolejnych wartości wpisując "0"

            Console.WriteLine("Średnia to: {0}", sum / i);
            Console.WriteLine("Średnia to: {0}", Math.Round(sum / i, 2)); // zaokrągla do dwóch miejsc po przecinku.

            Console.ReadKey();
        }
    }
}
