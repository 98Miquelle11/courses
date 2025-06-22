using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typ_wyliczeniowy__enum_ // Wyliczeniowy typ danych (typ enumeracyjny) definiuje się za pomocą słowa kluczowego enum, po którym podaje sie
    // ujety w znaki nawiasów klamrowych zbiór symboli określających dopuszczalne wartości danego typu. To reprezentacja danego zbioru.
{
    public enum Color // tworzymy tutaj zestaw etykiet nazw, które tylko w danym kontekście są prawdziwe
    {
        Black = 9, White, Brown
    }
    class Dog
    {
        public string name;
        public int age;
        public Color color;
        public Dog (string name, int age, Color color)
        {
            this.name = name;
            this.age = age;
            this.color = color;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog reks = new Dog("Reks", 10, Color.Black);
            Dog azor = new Dog("Azor", 5, Color.Black);
            Console.WriteLine(reks.color.Equals(azor.color));
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Color.Black + " - " + (int)Color.Black);
            Console.WriteLine(Color.White + " - " + (int)Color.White);
            Console.WriteLine(Color.Brown + " - " + (int)Color.Brown);

            Console.ReadKey();
        }
    }
}
