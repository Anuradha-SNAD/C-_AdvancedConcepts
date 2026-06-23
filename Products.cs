using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Id={Id},Name={Name}";
        }
    }
}
