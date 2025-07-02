using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przeciążanie_operatorów
{
    class Punkt2D
    {
        public int x;
        public int y;
        public Punkt2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public static Punkt2D operator +(Punkt2D a, Punkt2D b) //operator +
        {
            return new Punkt2D(a.x + b.x, a.y + b.y);
        }
        public static Punkt2D operator +(Punkt2D a, int b) //operator +
        {
            return new Punkt2D(a.x + b, a.y + b);
        }
        // w ten sposób mamy dwa przeciążenia jednego operatora
        public void Show()
        {
            Console.WriteLine($"x = {x}, y = {y}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Punkt2D p1 = new Punkt2D(2,5);
            Punkt2D p2 = new Punkt2D(3, 4);
            Punkt2D p3 = p1 + p2; // teraz już nie ma błędu, ze względu na utworzenie operatora
            p1.Show();
            p2.Show();
            p3.Show();
            Punkt2D p4 = p1 + 10;
            p4.Show();

            Console.ReadKey();
        }
    }
}
