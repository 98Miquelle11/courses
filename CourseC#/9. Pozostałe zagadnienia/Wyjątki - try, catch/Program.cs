using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjątki___try__catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[1];
            try
            {
                int y = 2 / int.Parse("ABC");
                int x = 2 / int.Parse("0"); // nie możemy wpisać po prostu 0 bo pokaże nam błąd. Teraz system nie jest jeszcze w stanie zdiagnozować, czy to jest 0.
                //Console.WriteLine("Przerywa."); gdyby był tutaj, wyświetliłby się
                nums[1] = 2;
                Console.WriteLine("Przerywa."); // nie wyświetli się, ponieważ operacja skończy się na nums[1] = 2
            }
            catch (IndexOutOfRangeException ex) // przechwyć wyjątek indexoutofrangeexception to typ danych, ex to nazwa zmiennej
            {
                Console.WriteLine(ex.Message); // ex.Message daje nam tą samą informację co przy buggowaniu, ale bez buggowania
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) // ta klasa jest w stanie przechwycić wyjątki dowolnej klasy
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Wykona się i tak");
            }
            Console.WriteLine("Nie przerywa");

            Console.ReadKey();
        }
    }
}
