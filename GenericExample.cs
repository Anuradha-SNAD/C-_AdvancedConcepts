using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class GenericExample<T>
    {
        public T Value;

        public static void Print<T>(T value)
        {
            Console.WriteLine(value);
        }

    }
}
