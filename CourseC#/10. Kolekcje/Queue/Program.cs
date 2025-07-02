using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Poniedziałek"); // enqueue - do kolejki
            queue.Enqueue("Wtorek");
            queue.Enqueue("Środa");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"\nIlość: {queue.Count}");
            //Console.WriteLine(queue[0]); nie możemy w taki sposób dobrać się do kolejki
            Console.WriteLine(queue.Dequeue()); // usunięto jedną osobę
            Console.WriteLine($"\nIlość: {queue.Count}");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(queue.Peek()); // pokaże ostatni
            Console.WriteLine($"\nIlość: {queue.Count}");

            Console.ReadKey();
        }
    }
}
