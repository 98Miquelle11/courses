using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjątki___własne_wyjątki
{
    class SilniaException: Exception // przeciążamy
    {
        // public override string Message => base.Message; // w wersji lambda
        public override string Message
        {
            get { return "Wyjątek klasy Silnia";} // alternatywa w postaci domyślnej implementacji
        }
    }
    internal class Program
    {
        static int Silnia(int n)
        {
            if (n < 0)
            {
                // throw new Exception("Wyraz n w silni jest mniejszy od 0."); // throw odpowiada za wyrzucenie wyjątku
                throw new SilniaException(); // alternatywa
            }
            if (n == 0) return 1;
            else return n * Silnia(n-1);
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Silnia(-8));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
