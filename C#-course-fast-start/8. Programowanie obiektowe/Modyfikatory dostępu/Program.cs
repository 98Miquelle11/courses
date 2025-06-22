using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modyfikatory_dostępu
{
    public class A // nie można definiować prywatnych klas. Dla klas używamy albo internal albo public. Dostęp biblioteki wymaga użycia "public"
    {
        int defaultVar;

        private int privateVar; // w innej klasie wszystkie zmienne są dostępne z wyjątkiem tej
        protected int protectedVar;
        internal int internalVar; // kod jest dostępny tylko w obrębie własnego zespołu
        public int publicVar;

        protected internal int protectedInternalVar;
        private protected int privateProtectedVar;
        void Test()
        {

        }

    }
    class B : A
    {
        void Test()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A(); // protected nie zauważymy tu dlatego, ponieważ protected udostępnia tylko w dziedziczonych
        }
    }
}
