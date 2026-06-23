using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public static class MyExtensions
    {
        public static void Greet(this string name)
        {
            Console.WriteLine("Hello " + name);
        }
      
    }
}
