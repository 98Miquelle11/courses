using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_oraz_as
{
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Kształt");
        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Prostokąt");
        }
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Koło");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            Rectangle rectangle = new Rectangle();
            Circle circle = new Circle();

            shape = circle; // tu nie ma błędu, ponieważ "shape" jest rodzicem "circle". Zaszło niejawne rzutowanie na typ "shape"
            //circle = shape; // jest to niemożliwe
            //circle = (Circle)shape; // jest możliwe, w przypadku rzutowania jawnego
            //circle = (Circle)rectangle; // bracia w programowaniu nie mają względem siebie żadnych przywilejów. Nawet rzutowanie jawne będzie tu błędem
            //circle = (Circle)"Abc"; // nie może stać sie kołem, ponieważ nie ma z nim żadnego związku
            object obj = shape; // po object niejawnie dziedziczą wszystkie klasy. Nie będziemy mieć w jej przypadku właściwości z class circle itd.
            obj = rectangle;
            obj = circle;

            if (shape is Circle) // jesteśmy zabezpieczeni z wykonaniem bezpiecznego rzutowania na shape
            {
                circle = (Circle)shape;
                circle.Draw();
            }

            Console.WriteLine(shape is Circle); // zwraca nam wartość logiczną
            Console.WriteLine("==============");
            Console.WriteLine(shape as Circle); // as nie jest operandem, który zwraca wartość logiczną. Albo nic nie pokaże, albo przeciążenie
                                                // metody dla klasy .ToString

            circle = shape as Circle; // dla circle musimy wykorzystać klasę Circle
            circle.Draw(); // kształt stał się w tym momencie kołem i został przypisany do zmiennej circle
            Console.WriteLine("==============");
            rectangle = shape as Rectangle;
            rectangle.Draw(); // wyświetli się wyjątek mówiący o braku referencji. Tyczy się on, że mamy jakąś zmienną zadeklarowaną, ale nie mamy
                              // jej przypisanej. Nie możemy koła przypisać do prostokątu. as jednocześnie sprawdza i próbuje rzutować.
            // sama próba przypisania nie wyrzuci błędu. Próba odczytu już tak.

            Console.ReadKey();
        }
    }
}
