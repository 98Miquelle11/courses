using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static // klasa statyczna może przechowywać elementy składające się wyłącznie z elementów statycznych oraz metod statycznych
    // przykładem metody statycznej jest klasa Math()
{
    class Person
    {
        public string name;
        public int age;
        //public int count = 0;
        public static int count = 0; // static występuje tylko jeden raz na rzecz danej klasy
        public static void Count()
        {
            Console.WriteLine($"Jest nas {count}."); // nie mogą się w niej pojawić elementy, które są niestatyczne
        }
        public Person (string name, int age)
        {
            this.name = name;
            this.age = age;
            count++;
        }
        public void Hello()
        {
            Console.WriteLine($"Cześć, jestem {name} i mam {age} lat. Jest nas {count}."); // do metod niestatycznych możemy dodawać zmienne statyczne
            Count(); // można wyświetlać metodę statyczną za pomocą metody niestatycznej
            // na odwrót nie można. Nie da się wykorzystać metody niestatycznej w metodzie statycznej
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Person.count);
            Person p1 = new Person("Adrian", 26);
            p1.Hello();
            // Console.WriteLine(p1.count); nie możemy tak pisać
            Person.Count();
            Person p2 = new Person("Ania", 24);
            p2.Hello();
            //Console.WriteLine(p2.count); // tutaj jest 1 a nie dwa bo moment tworzenia nowej instancji to kopia szablonu. Kiedy tworzymy
            // nowy obiekt to zmienna count jest kopią tej wartości i należy do obiektu pierwszego. Kiedy tworzymy drugi obiekt to on też
            // ma swoją kopię - swoją wartość zmiennej count, w której przechowuje odrębną wartość. Zawsze więc będzie 1, ponieważ zmienna 
            // count jest indywidualna dla każdego obiektu

            Console.WriteLine(Person.count); // pole statyczne nie działa na rzecz obiektu (instancji) tylko na rzecz całej klasy

            // Math math = new Math(); jeśli najedziesz na nazwę klasy trzymając Ctr, i klikniesz dwa razy, przeniesie cię do jej struktury

            Console.ReadKey();
        }
    }
}
