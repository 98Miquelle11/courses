using System;
using Modyfikatory_dostępu; // trzeba dodać ten using

namespace MojaBiblioteka
{
    public class Class1 : A
    {
        A a = new A();
        void Test()
        {
            a.publicVar = 1; // mamy dostęp tylko do zmiennej publicznej (nawet jeśli dziedziczy)
            protectedVar = 2; // natomiast pozwala korzystanie ze zmiennej protected bezpośrednio
        }
    }
}