using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie___Wstęp
{
    class Animal
    {
        public string name; // private jest jednynym modyfikatorem dostępu, który nie zezwala na dziedziczenie cechy
        public int age;
        public void Show()
        {
            Console.WriteLine("I'm Animal");
        }
    }
    class Cat : Animal // każda klasa domyślnie (niejaswnie) w C# dziedziczy po klasie object
    {
        public void GetVoice()
        {
            Console.WriteLine("Meow meow!");
        }
    }
    class Tiger : Cat // dzięki temu klasa Tiger dziedziczy również po klasie Animal - czyli po wszystkich swoich przodkach
    {

    }
    class Dog : Animal //, Cat // nie można dziedziczyć od więcej niż jednego
    {
        public void Voice()
        {
            Console.WriteLine("Hau hau!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.age = 10;
            //cat.name = "Pchełka";
            cat.Show();
            cat.GetVoice();

            Animal animal = new Animal();
            //animal.GetVoice(); dziedziczenie nie zachodzi w obydwie strony
            animal.Show();
            Dog dog = new Dog();
            dog.Voice();
            Tiger tiger = new Tiger();
            tiger.Show();

            Console.ReadKey();
        }
    }
}
