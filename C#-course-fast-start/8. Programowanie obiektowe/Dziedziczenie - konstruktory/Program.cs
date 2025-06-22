using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie___konstruktory
{
    class Animal
    {
        public string name;
        public int age;
        //public Animal()
        //{
        //    Console.WriteLine("Konstruktor - Animal");
        //}
        public Animal(string name, int age)
        {
            this.name = name; // słowo kluczowe this wskazuje na dokładzie tą klasę (zasięg tej klasy), w której się teraz znajdujemy
            this.age = age;
        }
        public void Show()
        {
            Console.Write($"Imie: {name}, wiek: {age}");
        }
    }
    class Cat: Animal
    {
        public string color;
        //public Cat() // konstruktor domyślny próbuje wywołać konstruktor klasy Animal
        //{
        //    Console.WriteLine("Konstruktor - Cat");
        //}
        public Cat(string name, int age, string color) : base(name, age)// base("Cat", 1) // konstruktor Cat nie musi przyjmować parametrów, ale może
        {
            this.color = color;
        }
        public void Show()
        {
            base.Show(); // zaaplikuje również metodę z pierwotnej klasy
            Console.WriteLine($", kolor: {color}.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Milka", 10, "czarny"); // nie zaobserwujemy tych zmiennych dla : base("Cat", 1)
            cat.Show();

            Console.ReadKey();
        }
    }
}
