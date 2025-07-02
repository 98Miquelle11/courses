using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosta_gra___praktyka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd  = new Random(); // nowy obiekt klasy random
            int random = rnd.Next(1,11); // zwraca nam losową liczbę całkowitą między 1 a 10 (górna granica drugiej liczby
            // nie jest brana pod uwagę.
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(rnd.Next(1, 11));
            //}
            int user = 0; // gdzie tą wartość wybiera gracz?
            bool valid;
            int i = 0;
            bool[] array = new bool[10];

            Console.Title = "Zgadnij liczbę!"; // nadamy tytuł konsoli, która będzie wyświetlać wiadomości.
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Zgadnij liczbę od 1 do 10!\n");
            Console.ResetColor();

            do
            {
                do
                {
                    Console.Write("Podaj liczbę: ");
                    valid = int.TryParse(Console.ReadLine(),out user); // out user oznacza, że ta liczba może się zmienić, ale nie musi // try parse zwraca wartość bool
                    if (!valid)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Podaj prawidłową liczbę!");
                        Console.ResetColor();
                    }
                } while (!valid); // to samo co valid == false

                if(user <1 || user >10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Podaj liczbę z zakresu 1-10!");
                    Console.ResetColor();
                    continue; // dzięki temu kolejny obieg pętli jest kontynuowany
                }

                if(array[user-1]) // -1 dlatego bo wybory są od 1 do 10 a tablica od 0
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Podano tą samą liczbę.");
                    Console.ResetColor();
                    continue;
                }
                else
                {
                    array[user-1] = true; // po co to jest?
                }

                if(random < user)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Wylosowana liczba jest mniejsza od Twojej.");
                    Console.ResetColor ();
                }
                else if(random > user)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Wylosowana liczba jest większa od Twojej.");
                    Console.ResetColor();
                }
                i++;

            } while (user != random);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Brawo!!! Odgadłeś za {i} razem.");
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
