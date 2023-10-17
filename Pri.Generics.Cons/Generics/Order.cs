using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Generics.Cons.Generics
{
    public class Order<T>
    {
        public T Item { get; }
        public int Quantity { get; }
        public Order(T item, int quantity)
        {
            Item = item;
            Quantity = quantity;
        }
    }
}
