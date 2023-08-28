
using System;

namespace Basics
{
    public class Sample
    {
        public void TypeSample()
        {
            Console.WriteLine($"sbyte: MinValue = {sbyte.MinValue}, MaxValue = {sbyte.MaxValue}");
            Console.WriteLine($"short: MinValue = {short.MinValue}, MaxValue = {short.MaxValue}");
            Console.WriteLine($"int: MinValue = {int.MinValue}, MaxValue = {int.MaxValue}");
            Console.WriteLine($"long: MinValue = {long.MinValue}, MaxValue = {long.MaxValue}");

            Console.WriteLine($"byte: MinValue = {byte.MinValue}, MaxValue = {byte.MaxValue}");
            Console.WriteLine($"ushort: MinValue = {ushort.MinValue}, MaxValue = {ushort.MaxValue}");
            Console.WriteLine($"uint: MinValue = {uint.MinValue}, MaxValue = {uint.MaxValue}");
            Console.WriteLine($"ulong: MinValue = {ulong.MinValue}, MaxValue = {ulong.MaxValue}");

            Console.WriteLine($"float: MinValue = {float.MinValue}, MaxValue = {float.MaxValue}");
            Console.WriteLine($"double: MinValue = {double.MinValue}, MaxValue = {double.MaxValue}");
            Console.WriteLine($"decimal: MinValue = {decimal.MinValue}, MaxValue = {decimal.MaxValue}");
        }

    }
}

