using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm__virtual_ // polimorfizm - wielopostaciowość
    // zadaniem polimorfizmu jest to, żeby nie ukrywać tych metod, które są dziedziczone
{
    internal class Program
    {
        class Shape
        {
            public virtual void Draw() // narysuj
            {
                Console.WriteLine("Kształt");
            }
        }
        class Rectangle : Shape
        {
            public new void Draw() // dodając "new" informujemy, że to nowa implementacja i metoda nie przyszłania metody w klasie pierwotnej
            {
                Console.WriteLine("Prostokąt");
            }
        }
        class Circle : Shape
        {
            public override void Draw() // override nadpisze oryginalną metodę
            {
                Console.WriteLine("Koło");
            }
        }
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            Rectangle rectangle = new Rectangle();
            Circle circle = new Circle();
            shape.Draw();
            rectangle.Draw();
            circle.Draw();
            
            Shape rectangleShape = new Rectangle(); // możliwość wcielania się w różne formy przez dany obiekt. Tutaj obiekt kształt
                                                    // przyjął formę prostokąta. Dozwolone jest przejęcie innej formy wtedy i tylko wtedy,
                                                    // kiedy klasa ma coś wspólnego z naszym rodzicem - musi istnieć powiązanie
            // Rectangle shapeRectangle = new Shape(); // to jest niedozwolone
            rectangleShape.Draw(); // wyświetli się treść wersji metody klasy Shape
            ((Shape)rectangle).Draw(); // ten sam efekt, co wyżej, tylko bez tworzenia nowej, później niepotrzebnej instancji
            ((Shape)circle).Draw();
            Console.WriteLine("===============");
            //Rectangle[] rectangles = new Rectangle[2];
            //rectangles[0] = rectangle;
            //rectangles[1] = cirlce; // bracia nic dla siebie nie oznaczają

            Shape[] shapes = new Shape[2];
            shapes[0] = rectangle;
            shapes[1] = circle;
            Console.WriteLine("Foreach:");
            foreach(Shape item in shapes)
            {
                item.Draw();
            }
            Console.WriteLine("===============");
            shape = rectangle;
            shape.Draw();
            Rectangle rectangle2 = (Rectangle)shape; // musimy przerzutować, ponieważ jest on zdefiniowany jako prostokąt (niepoprawna odwrócona kolejność)
            rectangle2.Draw();

            Console.ReadKey();
        }
    }
}
