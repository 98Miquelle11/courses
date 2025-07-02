using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermetyzacja__enkapsulacja_ // Hermetyzacja to ukrywanie pól i robienie z nich pól prywatnych. Ukrywanie zmiennych na zewnątrz.
{
    class Person
    {
        string name; // żeby inna klasa miała dostęp do tego pola, musimy zrobić dwie metody na rzecz jednej zmiennej,
                     // jeśli chcemy mieć zarówno możliwość modyfikacji tego pola i dostępu do niego (odczytu)
        public string getName()  // to nie jest pole tylko metoda
        {
            return "Imie: " + name;
        }
        public void setName(string value)
        {
            if (value.Length > 2) name = value;
        }
        private int age;
        public int Age // prostszy sposób nadania dostępu - utworzenie WŁAŚCIWOŚCI
        {
            get { return age; }
            set { if (value >= 0 && value <= 200) age = value; }
        }
        public string Country { get; set; } // właściwość, mająca jednocześnie cechy pola
        //private int myVar; // propfull pozwala nam utworzyć na szybko taki skrypt po dwukrotnym wciśnięciu tab

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}

        public Person (string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void Hello()
        {
            Console.WriteLine($"Cześć, jestem {name} i mam {age} lat.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Adrian",20);
            //p1.name = "-";
            p1.setName("Adam");
            p1.setName("-"); // nie zapisało się przez warunek w metodzie setName
            Console.WriteLine(p1.getName());
            p1.Age = 21; // właściwość to nie metoda. Nie zawiera na końcu nawiasów.
            Console.WriteLine(p1.Age);
            p1.Country = "Poland";
            Console.WriteLine(p1.Country);

            p1.Hello();

            Console.ReadKey();
        }
    }
}
