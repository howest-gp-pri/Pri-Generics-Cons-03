﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Generics.Cons.Generics
{
    public class Repository<T> : IRepository<T>
    {
        private readonly List<T> _data = new List<T>();
        public void Add(T toAdd)
        {
            _data.Add(toAdd);
        }

        public void Delete(T toDelete)
        {
            _data.Remove(toDelete);
        }

        public T Get(int index)
        {
            return _data[index];
        }

        public IEnumerable<T> GetAll()
        {
            return _data;
        }
    }
}
