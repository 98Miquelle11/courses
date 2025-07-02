using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract // dzięki niej możemy oznaczać metody, które nie muszą (nie mogą) deklarować swojego ciała
{
    abstract class Shape // jeżeli chociaż jedna metoda w klasie jest abstrakcyjna, to musimy nadać całej klasie słowo kluczowe abstract
    {
        // public abstract virtual void Draw() // abstract z definicji jest wirtualne
        public abstract void Draw(); // w takiej sytuacji dodajemy średnik ;
        //{
            //Console.WriteLine("Kształt"); // metoda abstrakcyjna nie może implikować żadnego ciała w swojej metodzie
        //}
        public void Hello()
        {
            Console.WriteLine("Coś tam.");
        }
    }
    abstract class Rectangle : Shape // w klasach dziedziczących musimy zadbać o implementację wszystkich metod typu abstract
    {                                // chyba, że sama będzie klasą abstrakcyjną

    }
    class Square : Rectangle  // w klasach dziedziczących nieabstrakcyjnych musimy zadbać o implementację wszystkich metod typu abstract
    {                         // chyba, że zostanie zaimplementowana przez klasę wcześniejszą w hierarchii
        public override void Draw()
        {
            throw new NotImplementedException();
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
            //// Shape shape = new Shape(); // nie można instancjonować abstrakcyjnej klasy
            //Rectangle rectangle = new Rectangle();
            //Circle circle = new Circle();
            ////shape.Draw();
            //rectangle.Draw();
            //circle.Draw();
            //rectangle.Hello(); // mogą być metody z ciała kasy abstrakcyjnej

            Console.ReadKey();
        }
    }
}
