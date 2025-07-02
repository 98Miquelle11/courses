using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struktury__struct_
{
    struct Punkt2D
    {
        public float x;
        public float y;
        public Punkt2D(float x, float y) // jeśli chcemy stworzyć konstruktor w strukturze, musi on posiadać co najmniej 1 parametr.
        {
            this.x = x;
            this.y = y;
        }
        public void Show()
        {
            Console.WriteLine($"x = {x}, y = {y}.");
        }
    }
    //struct Punkt3D // : Punkt 2D dziedziczenie w strukturach nie zachodzi
    class Punkt3D
    {
        public float x, y, z;
        public Punkt3D (float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void Show()
        {
            Console.WriteLine($"x = {x}, y = {y}, z = {z}.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Punkt2D p1; // struct nie ma konstruktora domyślnego, dlatego musimy od razu zdefiniować zmienną.
            p1.x = 2;
            p1.y = 3;
            p1.Show();
            Punkt2D p2 = new Punkt2D(3,4);

            p2 = p1;
            p2.x = 20;
            p2.y = 30;
            p2.Show();
            p1.Show();

            Punkt3D p3 = new Punkt3D(2, 3, 4);
            Punkt3D p4;
            p4 = p3;
            p4.x = 20;
            p4.y = 30;
            p4.z = 40;
            p4.Show();
            p3.Show(); // obydwie instancje posiadają te same wartości, ponieważ posiadają kopię referencji na ten sam obiekt

            Console.ReadKey();
        }
    }
}
