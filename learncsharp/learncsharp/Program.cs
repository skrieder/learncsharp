using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            // Eight C# predefined integer types:

            sbyte i1 = -128;
            short i2 = -32768;
            int i3 = -2147483648;
            long i4 = -9223372036854775808;
            byte i5 = 255;
            ushort i6 = 65535;
            uint i7 = 4294967295;
            ulong i8 = 18446744073709551615;

            // print examples
            Console.WriteLine("i1 = {0}",i1);
            Console.WriteLine("i2 = {0}", i2);
            Console.WriteLine("i3 = {0}", i3);
            Console.WriteLine("i4 = {0}", i4);
            Console.WriteLine("i5 = {0}", i5);
            Console.WriteLine("i6 = {0}", i6);
            Console.WriteLine("i7 = {0}", i7);
            Console.WriteLine("i8 = {0}", i8);

            Console.ReadLine();

        }
    }
}
