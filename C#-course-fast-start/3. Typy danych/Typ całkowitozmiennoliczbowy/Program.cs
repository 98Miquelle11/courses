using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typ_całkowitozmiennoliczbowy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte varByte = 100;
            //Console.WriteLine(varByte);
            Console.WriteLine($"Byte min: {byte.MinValue}, max: {byte.MaxValue}");

            short varShort = 3000;
            Console.WriteLine($"Short min: {short.MinValue}, max: {short.MaxValue}");

            int varInt = 300000;
            Console.WriteLine($"Int min: {int.MinValue}, max: {int.MaxValue}");

            long varlong = 3000000000;
            Console.WriteLine($"Long min: {long.MinValue}, max: {long.MaxValue}");
            Console.WriteLine();
            Console.WriteLine("=====================================================================");
            Console.WriteLine();
            // poniższe zmienne powstały by dać 2 razy więcej pamięci, kosztem wartości ujemnych.
            ushort varUShort = 3000;
            Console.WriteLine($"uShort min: {ushort.MinValue}, max: {ushort.MaxValue}");
            
            uint varUInt = 100;
            Console.WriteLine($"uInt min: {uint.MinValue}, max: {uint.MaxValue}");

            ulong varULong = 3000000000;
            Console.WriteLine($"uLong min: {ulong.MinValue}, max: {ulong.MaxValue}");
            Console.WriteLine();
            Console.WriteLine("=====================================================================");
            Console.WriteLine();
            // mamy jeszcze sbyte, który przeżuca połowę na ujemne
            sbyte varSByte = 100;
            //Console.WriteLine(varSByte);
            Console.WriteLine($"sByte min: {sbyte.MinValue}, max: {sbyte.MaxValue}");
            
            Console.ReadKey();
        }
    }
}
