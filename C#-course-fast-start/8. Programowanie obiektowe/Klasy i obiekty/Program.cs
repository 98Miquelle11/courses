using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_i_obiekty
{
    //class Person // klasy są swego rodzaju przepisem na dany obiekt (jak przepis kulinarny), ale nie są jeszcze reprezentacją/obiektem
    //{
    //    public string name; // przechowuje imie danej osoby
    //    public int age; // przechowuje wiek
    //    public void hello() // metoda, która nic nie zwraca
    //    {
    //        Console.WriteLine($"Cześć, jestem {name} i mam {age} lat.");
    //    }
    //}
    internal class Program // do niedawna programomanie odbywało się w języku strukturalnym.
    {
        static void Main(string[] args) // klasy nie są funkcjami, nie są metodami i nie wywołują jej w sposób metod
        {
            Person p1 = new Person(); // konstruktor wymaga nawiasów, ze względu na konstruktor klasy.
            p1.name = "Michał";
            p1.age = 22;
            p1.hello(); // odwołanie do klasy i metody

            Person p2 = new Person();
            p2.name = "Ania";
            p2.age = 24;
            p2.hello();

            Console.ReadKey();
        }
    }
}
