using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice__Array_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int []arr = { 1, 5, 10, -7, 8, 3, 0, -6, -10, 2};
            Array.Sort(arr);
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0,4}", arr[i]);
            } // albo
            Console.WriteLine();
            Array.Reverse(arr);
            Array.ForEach(arr, i => Console.Write("{0,4}", i));
            Console.WriteLine();
            arr = Array.FindAll(arr, i => i % 2 == 0);
            Array.ForEach(arr, i => Console.Write("{0,4}", i));
            Console.WriteLine();
            Array.Resize(ref arr, 10); // resize - zmień rozmiar. Trzeba zastosować referencję. Zmieniliśm rozmiar na 10 elementów. Dlatego
                                       // dla brakujących pokaże nam zera
            Array.ForEach(arr, i => Console.Write("{0,4}", i));
            Console.WriteLine();
            Array.Clear(arr,0,2); // od pierwszego elementu wyczyścimy 2 elementy
            Array.ForEach(arr, i => Console.Write("{0,4}", i));
            Console.WriteLine();
            //arr = Array.Empty<int>();
            Array.ForEach(arr, i => Console.Write("{0,4}", i)); // całkowite wyczyszczenie tablicy
            Console.WriteLine();
            Console.WriteLine(Array.Exists(arr,i => i == -10)); // sprawdza czy istnieje
            Console.WriteLine(Array.IndexOf(arr,-10));

            Console.ReadKey();
        }
    }
}
