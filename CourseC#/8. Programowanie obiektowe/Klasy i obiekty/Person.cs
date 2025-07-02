using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_i_obiekty
{
    internal class Person
    {
        public string name; // przechowuje imie danej osoby
        public int age; // przechowuje wiek
        public void hello() // metoda, która nic nie zwraca
        {
            Console.WriteLine($"Cześć, jestem {name} i mam {age} lat.");
        }
    }
}
