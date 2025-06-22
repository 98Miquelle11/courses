using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readonly
{
    class Test
    {
        public const int varConst = 4; // stała musi być od razu oznaczona przez jakąś wartość 
        public static readonly int varReadonly = 1; // readonly - tylko do odczytu
        static Test() // specjalny konstruktor statyczny
        {
            varReadonly = 2; // pod warunkiem, że modyfikowane pole również jest statyczne
            // w prypadku działania tego konstruktora, nie będzie działał konstruktor poniżej
        }
        public Test(int n)
        {
            //varConst = n; // nie ma możliwości ponownego zadeklarowania
            varReadonly = n; // jest możliwość ponownego zadeklarowania w konstruktorze
        }
        void Change() // bez względu na to czy będzie static czy non-static
        {
            //varConst = 3; ma już przypisaną wartość, której nie można zmienić
            //varReadonly = 3; jest przypisana tylko do odczytu
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test(2);
            Test test2 = new Test(3);
            //test.varReadonly = 2;
            //Test.varConst = 2;
            Console.WriteLine(test.varReadonly);
            Console.WriteLine(test2.varReadonly);
            // Console.WriteLine(test.varConst); pojawi się błąd

            Console.ReadKey();
            // jeżeli instancji byłoby więcej, to dla każdej z nich może być inna wartość Readonly
        }
    }
}
