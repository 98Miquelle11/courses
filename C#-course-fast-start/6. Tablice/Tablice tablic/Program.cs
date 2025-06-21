using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice_tablic
{
    internal class Program
    {
        static void Main(string[] args)
        { // [][] oznacza, że typ int ma być przechowywany w tablicy tablic
            int[][] array = new int[3][]; // nie można zadeklarować drugiego wymiaru tablicy
            array[0] = new int[5]; // ilość elementów w poszczególnych wierszach
            array[1] = new int[3];
            array[2] = new int[7];

            array[0][0] = 1;
            array[2][6] = 9;

            Console.WriteLine(array[0][0]);
            Console.WriteLine(array[2][6]);

            Console.WriteLine("\nFor:");

            for (int i = 0; i < array.Length; i++) // jeden sposób wyświetlenia
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nForeach");
            foreach (int[] array2 in array) // drugi sposób wyświetlenia
            {
                foreach (int item in array2)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
