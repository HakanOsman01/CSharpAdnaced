namespace Problem02.Stack
{
    using CustomStack;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class CustomStack<T>:IEnumerable<T>
    {
        private Node<T> top;
        private Node<T> head;
      
       
        
        public int Count { get; private set; }

        public bool Contains(T item)
        {
            Node<T> bottom = head;
            while (bottom != null)
            {
                if (bottom.Value.Equals(item))
                {
                    return true;
                }
                bottom = bottom.Next;

            }
            return false;
        }

        public T Peek()
        {
            return top.Value;
        }

        public T Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("This stack is Empty");
            }
            else
            {
                Node<T> bottomNode = top;
                T value = bottomNode.Value;
                top = bottomNode.Previos;
                bottomNode = null;
                Count--;
                return value;
            }
        }

        public void Push(T item)
        {
            Node<T> pushNode = new Node<T>(item);
            if (Count == 0)
            {
                head = pushNode;
                top=head;
                
            }
            else
            {

                top.Next = pushNode;
                pushNode.Previos = top;
                top = pushNode;
            }
            Count++;

        }

        public IEnumerator<T> GetEnumerator()
        {

            while (Count > 0)
            {
                yield return this.Pop();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}
