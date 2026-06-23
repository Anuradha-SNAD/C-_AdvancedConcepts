using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class Repository<T>
    {
        List<T> list = new List<T>();

        public void Add(T i)
        {
            list.Add(i);
        }

        public List<T> GetAll()
        {
            return list;
        }
    }
}
