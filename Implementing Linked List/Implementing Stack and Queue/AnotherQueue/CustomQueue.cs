namespace Problem03.Queue
{
    using AnotherQueue;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class CustomQueue<T> : IEnumerable<T>,IComparable<T> where T : IComparable
    {
        private Node<T> head;
        private Node<T> tail;
     

        public int Count { get; private set; }

        public bool Contains(T item)
        {
            Node<T> currentNode = head;
            while (currentNode != null)
            {
                int compare = CompareTo(item,currentNode.Value);
                if (compare==0)
                {
                    return true;
                }
                currentNode = currentNode.Next;
            }
            return false;
        }

        public T Dequeue()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Emprty Queue");
            }
            else
            {
                Node<T>oldHead=head;
                T value = oldHead.Value;
                head= oldHead.Next;
                oldHead.Next = null;
                Count--;
                return value;
            }
           

        }

        public void Enqueue(T item)
        {
            Node<T> newItem = new Node<T>(item);
            if (Count == 0)
            {
                head=newItem;
                tail=newItem;

               
               
             
            }
            else
            {
                 Node<T> lastTail = tail;
                 lastTail.Next = newItem;
                 tail = newItem;




            }
           
            Count++;


        }

        public T Peek()
        {
            return this.head.Value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            while(Count>0)
            {
                yield return this.Peek();
                this.Dequeue();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();

        public int CompareTo(T other,T next)
        {
            if (other.CompareTo(next) == 0)
            {
                return 0;
            }
            return 1;
        }

        public int CompareTo(T? other)
        {
            throw new NotImplementedException();
        }
    }
}