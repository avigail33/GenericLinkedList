using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLinkedList
{
    public class MyItem<T> : IMyItem<T>
    {
        public T Content { get; }

        public IMyItem<T> NextItem { get; set; }

        public MyItem(T content)
        {
            Content = content;
            NextItem = null;
        }
    }
}
