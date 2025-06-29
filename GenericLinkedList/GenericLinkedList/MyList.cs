using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLinkedList
{
    public class MyList<T> : ICollection<T>
    {
        public int Count { get; set; }
        public bool IsReadOnly { get; set; }
        public IMyItem<T> HeadItem { get; set; }

        public MyList(int count, IMyItem<T> head)
        {
            Count = count;
            HeadItem = head;
            IsReadOnly = false;
        }

        public void Add(T item)
        {
            MyItem<T> myItem = new MyItem<T>(item);

            if (HeadItem == null)
            {
                HeadItem = myItem;
            }

            else
            {
                IMyItem<T> currentNode = HeadItem;
                while (currentNode.NextItem != null)
                {
                    currentNode = currentNode.NextItem;
                }

                currentNode.NextItem = myItem;
            }
            Count++;
        }

        public void Clear()
        {
            Count = 0;
            HeadItem = null;
        }

        public bool Contains(T item)
        {
            IMyItem<T> currentNode = HeadItem;
            while(currentNode != null)
            {
                if(currentNode.Content.Equals(item))
                {
                    return true;
                }
                currentNode = currentNode.NextItem;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            if(HeadItem == null)
            {
                return false;
            }

            if (HeadItem.Content.Equals(item))
            {
                HeadItem = HeadItem.NextItem;
                Count--;
                return true;
            }

            IMyItem<T> currentNode = HeadItem;

            while (currentNode.NextItem != null)
            {
                if (currentNode.NextItem.Content.Equals(item))
                {
                    Count--;
                    currentNode.NextItem = currentNode.NextItem.NextItem;
                    return true;
                }
                currentNode = currentNode.NextItem;
            }

            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
