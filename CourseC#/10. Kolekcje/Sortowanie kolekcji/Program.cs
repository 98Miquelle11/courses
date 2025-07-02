using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie_kolekcji
{
    public class Person : IComparable<Person>
    {
        protected string name;
        protected int age;
        public Person (string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public int CompareTo(Person other) // warunek możliwości zaimplementowania interfejsu IComparable
        {
            //if (this.age > other.age) return 1;
            //else if (this.age < other.age) return -1;
            //else return 0; // możemy też zrobić w inny sposób
            //return this.age.CompareTo(other.age);
            return (this.age.CompareTo(other.age)*10) + this.name.CompareTo(other.name); // teraz kategoryzuje również alfabetycznie
            // mamy część dziesiątek i część jedności
        } // zajdzie sortowanie ze względu na wiek

        public override string ToString() // przeciążenie metody
        {
            return $"{age} - {name}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Maciej", 19);
            Person p2 = new Person("Ola", 18);
            Person p3 = new Person("Sebastian", 26);
            Person p4 = new Person("Asia", 19);
            Person p5 = new Person("Marcin", 22);
            Person p6 = new Person("Ania", 18);
            Person p7 = new Person("Łukasz", 24);
            Person p8 = new Person("Bartek", 18);

            List<Person> list = new List<Person>();
            list.Add(p1);
            list.Add(p2);
            list.Add(p3);
            list.Add(p4);
            list.Add(p5);
            list.Add(p6);
            list.Add(p7);
            list.Add(p8);

            list.Sort(); //obiekty klasy Person nie mają domyślnej zdolności do porównywania się względem siebie
                         // Aby posortować dane elementy względem siebie, musimy dokonać wg algorytmu szeregu porównań względem siebie
            Console.WriteLine(p1.Equals(p2));

            foreach(var item in list)
            {
                Console.WriteLine(item.ToString());
            }
            //Console.WriteLine(5.CompareTo(6));
            //Console.WriteLine("Ala".CompareTo("Ola"));

            Console.ReadKey();
        }
    }
}
