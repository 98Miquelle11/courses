using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoda_ToString
{
    class Punkt3D
    {
        public float x, y, z;
        public Punkt3D(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.y = y;
        }
        //public string Show()
        //{
        //    return $"x = {x}, y = {y}, z = {z}"; 
        //}
        public override string ToString() // wyświetl pierwsze wykorzystanie tej metody, używając wbudowanego ToString (z klasy object), nie tego
        {
            return $"x = {x}, y = {y}, z = {z}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Punkt3D p1 = new Punkt3D(2, 5, 10);
            //Console.WriteLine(p1.Show());
            Console.WriteLine(p1.ToString()); // zwrócono nam przestrzeń nazw i nazwę klasy, do której się odwołujemy
            // to tzw domyślna reprezentacja metody ToString z klasy object, jeżeli sami jej nie ustanowimy/nie nadpiszemy
            Console.WriteLine(p1.ToString()); // teraz jej przeciążenie zostało zmienione
            Console.WriteLine(((object)p1).ToString()); // gdyby słówka przysłonili dziedziczonej metody, wyświetłiłoby nam się to, co na początku
            Console.WriteLine(p1); // zaletą przeciążenia metody ToString jest to, że program sam się domyśla teraz co ma zrobić. 
                                   // Metoda ToString używana jest automatycznie

            Console.ReadKey();
        }
    }
}
