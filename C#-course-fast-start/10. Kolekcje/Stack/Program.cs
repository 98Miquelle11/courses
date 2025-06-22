using System;
using System.Collections.Generic; // ten using jest wykorzystywany przez kolekcje
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1); // ta metoda służy nam do dodawania czegoś do naszego stosu
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            foreach (var item in stack)
            {
                Console.WriteLine(item); // będą wyświetlane od końca do początku
            }
            Console.WriteLine($"\nIlość: {stack.Count}");
            Console.WriteLine(stack.Pop()); // usuwa ostatni element
            Console.WriteLine($"Ilość: {stack.Count}\n");
            foreach (var item in stack)
            {
                Console.WriteLine(item); // będą wyświetlane od końca do początku
            }
            Console.WriteLine("\n" + stack.Peek()); // podejrzewa ostatni element

            Console.ReadKey();
        }
    }
}
