using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktor
{
    class Person
    {
        //public Person(string n, int a) // konstruktor, w argumentach szukany jest najbliższy zakres tej zmiennej
        //{
        //    name = n; // przypisanie
        //    age = a;
        //}
        public Person(string name, int age) // konstruktor, w argumentach szukany jest najbliższy zakres tej zmiennej
        {
            this.name = name; // this przeszukuje w pierwszej kolejności obszar o zasięgu całej klasy. Wtedy nie trzeba zmieniać
            this.age = age;   // nazwy. this ignoruje deklaracje w konstruktorze, bo patrzy na całą klasę
        }
        public Person (string name)
        {
            this.name = name;
            age = 1;
        }

        public string name; // = "Anonim"
        public int age; // = 1; te definicje rozwiążą poniższy problem, ale będą to wartości domyślne
        public void hello()
        {
            Console.WriteLine($"Cześć, jestem {name} i mam {age} lat/a.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Michał", 22);
            p1.hello(); // przestawienie metody tutaj spowoduje, że nie będzie żadnych danych
            p1.name = "Michał";
            p1.age = 22;

            Person p2 = new Person("Ania"); // wiek zapisaliśmy bezpośrednio w konstruktorze
            p2.hello();
            p2.name = "Ania";
            p2.age = 24;

            Console.ReadKey();
        }
    }
}
