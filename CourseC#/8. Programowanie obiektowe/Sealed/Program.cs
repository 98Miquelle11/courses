using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed
{
    class Animal
    {

    }
    sealed class Cat : Animal // zaplombowanie - oznaczamy klasę cat jako finalną, której nie da się już odziedziczyć (forma zabezpieczenia)
    {

    }
    class Dog : Animal
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
