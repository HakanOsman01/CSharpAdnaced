using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementsLinkedList
{
    public class DoubleLinkedList<T>
    {
        public int Count { get; set; }
        public LinkedListNode<T> Head { get; private set; }
        public LinkedListNode<T> Tail { get;private set; }
        public bool IsEmpty =>this.Count == 0;
        public void AddHead(T value)
        {
            if (IsEmpty)
            {
                //var newNode = new LinkedListNode(value);
                this.Head = this.Tail = new LinkedListNode<T>(value);
            }
            else
            {
                var previosHead = this.Head;
                var newNode= new LinkedListNode<T>(value);
                previosHead.Previos = newNode;
                newNode.Next = previosHead;
                this.Head= newNode;

            }
            this.Count++;
        }
        public void AddTail(T value)
        {
            if (this.IsEmpty)
            {
                this.Head=this.Tail = new LinkedListNode<T>(value);
            }
            else
            {
                var previosTail = this.Tail;
                var newNode= new LinkedListNode<T>(value);
                newNode.Previos= previosTail;
                previosTail.Next = newNode;
                this.Tail= newNode;
            }
            this.Count++;
        }

       // public IEnumerator<T> GetEnumerator()=>GetEnumerator();
      

        public T RemoveHead()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("List is empty");
            }
            var removedHead = this.Head;
            var removedValueHead = this.Head.Value;
            var nextHead=removedHead.Next;
            if (nextHead == null)
            {
                this.Head = this.Tail = null;
            }
            else
            {
                nextHead.Previos = null;
                removedHead.Next = null;
                this.Head = nextHead;

            }
            this.Count--;
            return removedValueHead;
        }
        public T RemoveTail()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("List is empty");


            }
            var removedTail = this.Tail;
            var removetTailValue = removedTail.Value;
            var nextTail=removedTail.Previos;
            if(nextTail == null)
            {
                this.Tail = null;
                this.Head = null;
            }
            else
            {
                nextTail.Previos = null;
                nextTail.Next = null;
                this.Tail= nextTail;

            }
            this.Count--;
            return removetTailValue;
        }
        public void ForEach(Action<T> action)
        {
            var currentNode = this.Head;
            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.Previos;
            }
        }

        public T[] ToArray()
        {
            T[]array=new T[this.Count];
            var currentNode=this.Head;
            int counter = 0;
            while(currentNode != null)
            {
                array[counter] = currentNode.Value;
                currentNode= currentNode.Next;
                counter++;
            }
            return array;
        }

        

        public class LinkedListNode<T>
        {
            public LinkedListNode(T value)
            {
                Value = value;
            }
            public T Value { get; set; }
            public LinkedListNode<T> Next{get;set;}
            public LinkedListNode<T> Previos { get; set; }
        }
        public void Reverse()
        {
            
                 LinkedListNode<T> swap;
                 swap = this.Head;
                 this.Head = this.Tail;
                 this.Tail = swap;
           

        }
    }
}
