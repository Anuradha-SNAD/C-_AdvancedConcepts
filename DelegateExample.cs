using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public delegate int Calculator(int x, int y,int z);
    public class DelegateExample
    {
        public static int Add(int x, int y,int z ) 
        {
            return x + y +z;
        }
        public static int Mul(int x ,int y ,int z)
        {
            return x * y * z;
        }
        public static void Main()
        {
            Calculator c = Add;
            int res = c(30, 30, 40);
            Console.WriteLine("Total : "+res);
            Calculator c1 = Mul;
            int r = c1(2, 3, 4);
            Console.WriteLine("Multiplication : " + r);
        }

        
    }
}
