using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsy // są naturalnym rozszerzeniem klas abstrakcyjnych. Najczęściej są wykorzystywane do tego, żeby po nich mogły dziedziczyć
{                    // klasy (po dowolnej ilości interfejsów)
    abstract class Shape
    {
        public abstract void Draw();
    }
    class Rectangle : Shape, IArea
    {
        public float a;
        public float b;
        public Rectangle(float a, float b)
        {
            this.a = a;
            this.b = b;
        }

        public void Area()
        {
            Console.WriteLine($"Pole prostokąta to {Math.Round(a*b,2)}");
        }

        public override void Draw()
        {
            Console.WriteLine($"rostokąt: a = {a}, b = {b}");
        }
    }
    class Circle : Shape, IArea
    {
        public Circle(float r)
        {
            this.r = r;
        }
        public float r;
        public override void Draw()
        {
            Console.WriteLine($"Koło: r = {r}");
        }

        public void Area()
        {
            Console.WriteLine($"Pole koła to {Math.Round(Math.PI * r * r, 2)}");
        }
    }
    interface IArea //domyślną cechą interfejsu jest publiczność
    {
        void Area(); // interface niejako sam w sobie jest już abstrakcyjny, dlatego przy metodach nie trzeba dodawać przedrostka "abstract"
        //void Other()
        //{
        //    Console.WriteLine(); // nie działa, stara wersja C#??
        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10, 3);
            rectangle.Draw();
            Circle circle = new Circle(4);
            circle.Draw();
            rectangle.Area();
            circle.Area();

            Console.ReadKey();
        }
    }
}
