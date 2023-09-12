namespace Problem01.FasterQueue
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class FastQueue<T>:IEnumerable<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public int Count { get; private set; }

        public bool Contains(T item)
        {
           throw new NotImplementedException();
        }

        public T Dequeue()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Empty queue!!!");
            }
            else
            {
                Node<T> oldHead = head;
                T valueHead = oldHead.Item;
                head = oldHead.Next;
                oldHead.Previos = null;
                Count--;
                return valueHead;


            }

        }

        public void Enqueue(T item)
        {
            Node<T> node = new Node<T>(item);
            if (Count == 0)
            {
                head=tail=node;
                
            }
            else
            {
                tail.Next = node;
                node.Previos = tail;
                tail = node;

                
            }
            Count++;
        }

        public T Peek() => this.head.Item;


        public IEnumerator<T> GetEnumerator()
        {
            while (Count > 0)
            {
                yield return this.Dequeue();
                
            }

        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}