using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice_wielowymiarowe
{
    internal class Program
    {
        static void Main(string[] args)
        {                                 // 2 elementy w pierwszym wymiarze i 3 w drugim.
            int[,] array2D = new int[2, 3]; // n przecinków w kwadratowym nawiasie to n+1 wymiarów w tabnlicy
            array2D[0, 0] = 1;
            array2D[1, 2] = 9;
            Console.WriteLine(array2D[0,0]);
            Console.WriteLine(array2D[1,2]);
            Console.Write("Wymiary: ");
            Console.WriteLine(array2D.Length); // wyświetla całkowitą liczbę elementów tej tablicy
            Console.WriteLine(array2D.GetLength(0)); // wyświetla liczbę elementów 1szego wymiaru
            Console.WriteLine(array2D.GetLength(1)); // wyświetla liczbę elementów 2giego wymiaru

            for(int i = 0; i < array2D.GetLength(0); i++)
            {
                for(int j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.Write(array2D[i,j] + " ");
                }
                Console.WriteLine();// ta instrukcja jest potrzebna do wyświetlenia elementów obydwu wymiarów w dwóch wierszach.
            }
            Console.Write("\nArray 3D: ");
            int[,,] array3D = new int[2, 2, 2];
            array3D[0, 1, 0] = 9;
            Console.WriteLine(array3D[0, 1, 0]);

            Console.WriteLine("\nText Array:");
            string[,] textArray = { { "Hello", "World" }, { "Witaj", "Świecie" } };

            Console.WriteLine(textArray[0,0] + " " + textArray[0,1]);
            Console.WriteLine(textArray[1,0] + " " + textArray[1,1]);

            Console.WriteLine("\nForeach:");
            foreach(var item in textArray)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
