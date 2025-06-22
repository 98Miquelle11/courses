using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;  // threading oznacza wielowątkowość

namespace Wielowątkowość
{
    internal class Program
    {
        static void LongMethod(object n)
        {
            for (int i = 0; i < (int)n; i++)
            {
                Console.WriteLine($"ID {Thread.CurrentThread.ManagedThreadId} : {i}");
            }
        }
        static void Main(string[] args)
        {
            //LongMethid(10);
            Thread t1 = new Thread(new ParameterizedThreadStart(LongMethod)); // wątek musi wskazywać na jakąś metodę
            Thread t2 = new Thread(new ParameterizedThreadStart(LongMethod));

            t1.Start(50); // przyporządkował sobie cyfrę "3"
            t2.Start(50); // wątek czwarty
            
            // uruchomienie jednego wątku nie blokuje uruchomienia drugiego. Działają asynchronicznie 

            Console.ReadKey();
        }
    }
}
