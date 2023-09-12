
using System.Collections;

namespace LastDoubleLinkedList
{
    public class DoubleLinkedList<T> : IAbstractLinkedList<T>
    {
         Node<T> head;
         Node<T> tail;
        public int Count { get;private set; }

        public void AddFirst(T item)
        {
           Node<T>newNode=new Node<T> (item);
           if(Count == 0)
           {
                head=tail = newNode;

           }
           else
           {
                head.Next= newNode;
                newNode.Previous = head;
                head=newNode;


           }
           Count++;
        }

        public void AddLast(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (Count == 0)
            {
                head = tail = newNode;

            }
            else
            {
                tail.Previous = newNode;
                newNode.Next = tail;
                tail = newNode;


            }
            Count++;

        }

        public IEnumerator<T> GetEnumerator()
        {
            while(Count>0)
            {
                yield return this.GetFirst();
                this.RemoveFirst();
            }
        }

        public T GetFirst() => head.Item;
        

        public T GetLast()=>tail.Item;
       

        public T RemoveFirst()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("This linked list is emppty!!!");
            }
            else
            {
                var oldHead=head;
                T value = oldHead.Item;
                oldHead.Next = null;
                head=oldHead.Previous;
                Count--;    
                return value;
                
            }
        }

        public T RemoveLast()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("This linked list is emppty!!!");
            }
            else
            {
                var oldTail = tail;
                T value = tail.Item;
                tail.Previous = null;
                tail = oldTail.Next;
                Count--;
                return value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()=>GetEnumerator();
        private bool IsEmpty()=>Count==0;
      
    }
}
